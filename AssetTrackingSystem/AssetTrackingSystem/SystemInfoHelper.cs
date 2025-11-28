using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackingSystem
{
    internal class SystemInfoHelper
    {
        public static HardwareInfo GetHardwareInfo()
        {
            return new HardwareInfo
            {
                SystemName = GetSystemName(),
                Model = GetModel(),
                Manufacturer = GetManufacturer(),
                Type = "Hardware",
                IPAddress = GetIPAddress()
            };
        }

    }
}
