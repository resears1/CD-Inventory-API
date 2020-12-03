using CdInventoryApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CdInventoryApi.Repository
{
    public interface IInventoryRepo
    {
        Inventory AddInventory(Inventory inv);
        Inventory UpdateInventory(string id, Inventory inv);
        Dictionary<string, Inventory> GetInventory();
        Inventory DeleteItem(string id, Inventory inv);
        Inventory GetItem(string id, Inventory inv);
    }
}
