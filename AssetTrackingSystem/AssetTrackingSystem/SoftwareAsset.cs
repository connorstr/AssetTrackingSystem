using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackingSystem
{
    public class SoftwareAsset
    {
        public int SoftwareID { get; set; }

        public string OSName { get; set; }
        public string OSVersion { get; set; }
        public string OSManufacturer { get; set; }

        public DateTime DetectedDate { get; set; }

        public string Note { get; set; }

        public int? EmployeeID { get; set; }
    }
}
