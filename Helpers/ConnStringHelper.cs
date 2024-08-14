using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latih15_Sekolahku.Helpers
{
    public static class ConnStringHelper
    {
        public static string Get() 
            => $"Server=(local);Database=SekolahKu;Trusted_Connection=True;";
    }
}
