using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackingSystem
{
    public class HardwareInfo
    {        
            public string SystemName { get; set; }
            public string Model { get; set; }
            public string Manufacturer { get; set; }
            public string Type { get; set; } = "Hardware";
            public string IPAddress { get; set; }
    }
}
