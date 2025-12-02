using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackingSystem
{
    public static class Session
    {
        public static Employee CurrentUser { get; set; }

        public static bool IsAdmin =>
            CurrentUser?.Department == "IT";
    }
}

