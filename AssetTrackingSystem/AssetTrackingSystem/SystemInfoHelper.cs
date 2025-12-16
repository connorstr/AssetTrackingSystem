using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackingSystem
{
    /// <summary>
    /// helper used for the autodetection of system information
    /// keeps it in its own file to keep main code clean
    /// </summary>
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

        public static string GetSystemName()
        {
            return Environment.MachineName;
        }

        // Gets the hardware model
        public static string GetModel()
        {
            try
            {
                using var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
                foreach (ManagementObject obj in searcher.Get())
                {
                    return obj["Model"]?.ToString() ?? "Unknown";
                }
            }
            catch { }
            return "Unknown";
        }

        // Gets the manufacturer (Dell, HP, Lenovo, etc.)
        public static string GetManufacturer()
        {
            try
            {
                using var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
                foreach (ManagementObject obj in searcher.Get())
                {
                    return obj["Manufacturer"]?.ToString() ?? "Unknown";
                }
            }
            catch { }
            return "Unknown";
        }

        // Gets the active IPv4 address of the machine
        public static string GetIPAddress()
        {
            try
            {
                string ip = Dns.GetHostAddresses(Dns.GetHostName())
                               .FirstOrDefault(a => a.AddressFamily == AddressFamily.InterNetwork)?
                               .ToString();

                return ip ?? "Unknown";
            }
            catch
            {
                return "Unknown";
            }

        }
        public static SoftwareAsset GetSoftwareAsset()
        {
            return new SoftwareAsset
            {
                OSName = RuntimeInformation.OSDescription,
                OSVersion = Environment.OSVersion.Version.ToString(),
                OSManufacturer = "Microsoft",
                DetectedDate = DateTime.Now,
                Note = "Auto-detected OS",
                EmployeeID = Session.CurrentUser?.EmployeeID
            };
        }
    }
}
