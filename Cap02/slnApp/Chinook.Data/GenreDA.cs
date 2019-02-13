using Chinook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

//namespace Chinook.Data
//{
//    public class GenreDA:BaseConnection 
//    {

//        public int GetCount()
//        {
//            var result = 0;

//            var sql = "SELECT COUNT(1) FROM Genre";
//            /*1: Create una instancia sql DbConnection*/
//            using (IDbConnection cn = new SqlConnection(GetConnection()))
//            {
//                /*2: Create ua instancia de Command*/
//                IDbCommand cmd = new SqlCommand(sql);
//                cmd.Connection = cn;
//                cn.Open(); //Abriendo la conexion a la DB
//                           /*3. ejecutando el comando*/
//                result = (int)cmd.ExecuteScalar();
//            }

//            return result;
//        }

//        public List<Genre> GetGenresWithSP( string filterByname)
//        {
//            var result = new List<Genre>();
//            var sql = "USP_GetGenre";
//            using (IDbConnection cn = new SqlConnection(GetConnection()))
//            {
//                /*2: Create ua instancia de Command*/
//                IDbCommand cmd = new SqlCommand(sql);
//                cmd.CommandType = CommandType.StoredProcedure;
//                cmd.Connection = cn;

//                //Agregando el parametro
//                cmd.Parameters.Add(new SqlParameter("@pNombre", filterByname));

//                cn.Open(); //Abriendo la conexion a la DB
//                           /*3. ejecutando el comando*/

//                var indice = 0;
//                var reader = cmd.ExecuteReader();
//                while (reader.Read())
//                {
//                    indice = reader.GetOrdinal("GenreId");
//                    var GenreId = reader.GetInt32(indice);

//                    indice = reader.GetOrdinal("Name");
//                    var name = reader.GetString(indice);

//                    //result.Add(
//                    //        new Genre()
//                    //        {
//                    //            GenreId = genreId,
//                    //            Name = name
//                    //        }
//                    //    );
//                }
//            }

//            return result;
//        }
//    }
//}
