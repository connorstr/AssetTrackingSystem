using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackingSystem
{
    public class LinkedAssetView
    {
        public string HardwareName { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }

        public string OSName { get; set; }
        public string OSVersion { get; set; }
    }
}
