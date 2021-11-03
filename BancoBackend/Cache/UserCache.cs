using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Cache
{
    public static class UserCache
    {
        public static int IdClienteLogin { get; set; }
        public static int DniLogin { get; set; }
        public static string ClaveLogin { get; set; }
        public static string NombreLogin { get; set; }
        public static string ApellidoLogin { get; set; }
        public static string EmailLogin { get; set; }
    }
}
