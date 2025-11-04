using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackingSystem
{
    // corrolates asset with properties relating to the columns in the tbale
    public class Asset
    {
        public int AssetID {  get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Note { get; set; }

        public Asset() { } // default constructer
    }
}
