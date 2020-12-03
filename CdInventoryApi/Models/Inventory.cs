using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CdInventoryApi.Models
{
    public class Inventory
    {
        // Id is a string because Dictionaries don't like any kind of number as Key
        public string Id { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public int ReleaseYear { get; set; }
        public int CopiesAvailable { get; set; }
    }
}
