using CdInventoryApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CdInventoryApi.Repository
{
    public class InventoryRepo : IInventoryRepo
    {
        private readonly Dictionary<string, Inventory> _inventory;

        // Constructor
        public InventoryRepo()
        {
            _inventory = new Dictionary<string, Inventory>();
        }

        // Add Inventory
        // Adds a key/ value pair to the dictionary, key being the id, and the value being the
        // Inventory object.
        public Inventory AddInventory(Inventory inv)
        {
            _inventory.Add(inv.Id, inv);

            return inv;
        }

        // UpdateInventory
        // Sets the inventory object at the id/key given to the new Inventory object, "updating" it
        public Inventory UpdateInventory(string id, Inventory inv)
        {
            _inventory[id] = inv;

            return inv;
        }

        // GetInventory
        // Returns each listing in the inventory dictionary
        public Dictionary<string, Inventory> GetInventory()
        {
            return _inventory;
        }

        // DeleteItem
        // Removes item from the Dictionary at the key given
        public Inventory DeleteItem(string id, Inventory inv)
        {
            _inventory.Remove(id);

            return inv;
        }

        // GetItem
        // Returns an item from the dictionary at the key given
        public Inventory GetItem(string id, Inventory inv)
        {
            inv = _inventory[id];

            return inv;
        }
    }
}
