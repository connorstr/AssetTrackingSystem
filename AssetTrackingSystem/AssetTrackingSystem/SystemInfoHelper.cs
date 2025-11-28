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
        public static string GetSystemName()
        {
            return Environment.MachineName;
        }

        public static string GetManufacturer()
        {
            try
            {
                using var searcher = new ManagementObjectSearcher("SELECT Manufacturer FROM Win32_ComputerSystem");
                var info = searcher.Get().Cast<ManagementObject>().FirstOrDefault();
                return info?["Manufacturer"]?.ToString() ?? "Unknown";
            }
            catch { return "Unknown"; }
        }

        public static string GetModel()
        {
            try
            {
                using var searcher = new ManagementObjectSearcher("SELECT Model FROM Win32_ComputerSystem");
                var info = searcher.Get().Cast<ManagementObject>().FirstOrDefault();
                return info?["Model"]?.ToString() ?? "Unknown";
            }
            catch { return "Unknown"; }
        }

        public static string GetIPAddress()
        {
            try
            {
                var ipAddress = Dns.GetHostEntry(Dns.GetHostName())
                .AddressList.FirstOrDefault(a => a.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);

                return ipAddress?.ToString() ?? "Unknown";
            }
            catch
            {
                return "Unknown";
            }
        }

        public static string GetOSName()
        {
            return RuntimeInformation.OSDescription;
        }

        public static string GetOSVersion()
        {
            return Environment.OSVersion.Version.ToString();
        }

        public static string GetOSManufacturer()
        {
            return "Microsoft";
        }
    }
}
