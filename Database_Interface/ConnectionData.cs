using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Interface
{
    static class ConnectionData
    {
        public static string Server { get { return "localhost"; } }
        public static string Port { get { return "5432"; } }
        public static string UserID { get { return "postgres"; } }
        public static string Password { get { return "password123"; } }
        public static string DataBase { get { return "new_usersdb"; } }
    }
}
