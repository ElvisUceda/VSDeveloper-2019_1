using Chinook.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Dapper;

namespace Chinook.Data
{
   public class AlbumDapperDA:BaseConnection
    {
        public int GetCount()
        {
            var result = 0;

            var sql = "SELECT COUNT(1) FROM Album";
            /*1: Create una instancia sql DbConnection*/
            using (IDbConnection cn = new SqlConnection(GetConnection()))
            {
                result = cn.Query<int>(sql).Single();

            }

            return result;
        }
    }
}
