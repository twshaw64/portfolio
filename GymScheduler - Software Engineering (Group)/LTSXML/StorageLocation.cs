using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.AccessControl;

namespace LTSXML
{
    public static class StorageLocation
    {
        private static string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataStorage");
        public static string Logins
        {
            get
            {
                return Path.Combine(basePath, "Logins.xml");
            }
        }

        public static string Reports
        {
            get
            {
                return Path.Combine(basePath, "Reports.xml");
            }
        }

        public static string Bookings
        {
            get
            {
                return Path.Combine(basePath, "Bookings.xml");
            }
        }
    }
}
