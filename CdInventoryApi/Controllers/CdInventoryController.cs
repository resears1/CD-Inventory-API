using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CdInventoryApi.Models;
using CdInventoryApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

/*
    Program: CD Store Inventory API 
    Description: Using Postman, you can add items, update items, view items, view single items, and delete items.

    Example at the bottom.
*/


namespace CdInventoryApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CdInventoryController : ControllerBase
    {
        private readonly IInventoryRepo _repo;

        // Constructor
        public CdInventoryController(IInventoryRepo repo)
        {
            _repo = repo;
        }

        // Add item
        [HttpPost]
        [Route("AddInventory")]
        public ActionResult<Inventory> AddInventory(Inventory inv)
        {
            var inventory = _repo.AddInventory(inv);

            if (inventory == null)
            {
                return NotFound();
            }

            return inventory;
        }

        // Update item
        [HttpPost]
        [Route("UpdateInventory/{id}")]
        public ActionResult<Inventory> UpdateInventory(string id, Inventory inv)
        {
            var inventory = _repo.UpdateInventory(id, inv);

            if (inv.Id != id)
            {
                return NotFound();
            }

            return inventory;
        }

        // Display all items
        [HttpGet]
        [Route("DisplayInventory")]
        public ActionResult<Dictionary<string, Inventory>> GetInventory()
        {
            var inventory = _repo.GetInventory();

            if (inventory.Count == 0)
            {
                return NotFound();
            }

            return inventory;
        }

        // Get single item with id
        [HttpGet]
        [Route("DisplayItem/{id}")]
        public ActionResult<Inventory> GetItem(string id, Inventory inv)
        {
            var inventory = _repo.GetItem(id, inv);

            if (inventory == null)
            {
                return NotFound();
            }

            return inventory;
        }

        //  Delete item at id
        [HttpDelete]
        [Route("DeleteItem/{id}")]
        public ActionResult<Dictionary<string, Inventory>> DeleteItem(string id, Inventory inv)
        {
            _repo.DeleteItem(id, inv);

            if (inv.Id != id)
            {
                return NotFound();
            }

            return Ok();
        }

     
    }
}

/*
    Example:

        Step 1: POST to CdInventory/AddInventory
            Body:
                {
                "Id": "1",
                "Artist": "Michael Jackson",
                "Album": "Thriller",
                "ReleaseYear": 1985,
                "CopiesAvailabe": 24
                }

        Step 2: POST to CdInventory/AddInventory
            Body:
                {
                "Id": "2",
                "Artist": "Disturbed",
                "Album": "Indestructible",
                "ReleaseYear": 2008,
                "CopiesAvailabe": 11
                }

        Step 3: GET from CdInventory/DisplayInventory
            It should display both items

        Step 4: POST to CdInventory/UpdateInventory/2
            Body:
                {
                "Id": "2",
                "Artist": "Disturbed",
                "Album": "The Sickness",
                "ReleaseYear": 2000,
                "CopiesAvailabe": 7
                }

        Step 5: GET from CdInventory/DisplayItem/2
            It should display the updated item 2

        Step 6: DELETE at CdInventory/DeleteItem/1
               This should remove item 1

        Step 7: GET from CdInventory/DisplayInventory
            It should display item 2 only
            

        Finished :)
*/
