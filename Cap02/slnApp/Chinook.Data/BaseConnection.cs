using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class BaseConnection
    {
        public string GetConnection()
        {
            string cadenaConexion = "Data Source=PC99006\\SQLEXPRESS;" +
                                        "Initial Catalog=Chinook; " +
                                        "User ID=sa; Password=G@tit0_lusa";
            return cadenaConexion;
        }
    }
}
