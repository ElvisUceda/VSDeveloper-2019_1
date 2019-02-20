using Chinook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace Chinook.Data
{
    public class GenreDapperDA:BaseConnection 
  {
        public int GetCount()
        {
            var result = 0;

            var sql = "SELECT COUNT(1) FROM Genre";
            /*1: Create una instancia sql DbConnection*/
            using (IDbConnection cn = new SqlConnection(GetConnection()))
            {

                result = cn.Query<int>(sql).First();

            }

            return result;
        }

        public List<Genre> GetGenre()
        {
            var result = new List<Genre>();
            var sql = "SELECT GenreId,Name FROM Genre";
            using (IDbConnection cn = new SqlConnection(GetConnection()))
            {

                result = cn.Query<Genre>(sql).ToList();

            }

            return result;
        }
        public int InsertGenre(Genre entity)
        {
            var result = 0;
            using (IDbConnection cn
                = new SqlConnection(GetConnection()))
            {
                result = cn.Query<int>("usp_InsertGenre",
                     new { Name = entity.Name },
                     commandType: CommandType.StoredProcedure).Single();


            }

            return result;

        }


        //public bool UpdateGenre(Genre entity)
        //{
        //    var result = false;
        //    using (IDbConnection cn
        //        = new SqlConnection(GetConnection()))
        //    {
        //        cn.Query("usp_UpdateGenre",
        //            new { Name = entity.Name },
        //            new {GenreId = entity.GenreId},
        //            commandType: CommandType.StoredProcedure);

        //        result = true;
        //    }
        //    return result;
        //}


        public int DeleteGenre(Genre entity)
        {
            var result = 0;
            using (IDbConnection cn
                = new SqlConnection(GetConnection()))
            {
                cn.Open();
                IDbCommand command =
                    new SqlCommand("usp_DeleteGenre");
                command.Connection = cn;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@Name", entity.Name)
                    );

               // result = Convert.ToInt32(command.ExecuteScalar());

            }

            return result;

        }
    }
}
