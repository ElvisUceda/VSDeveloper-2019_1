using Chinook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Chinook.Data
{
    public class GenreDA:BaseConnection 
  {

       

        public int InsertGenre(Genre entity)
        {
            var result = 0;
            using (IDbConnection cn
                = new SqlConnection(GetConnection()))
            {
                cn.Open();
                IDbCommand command =
                    new SqlCommand("usp_InsertGenre");
                command.Connection = cn;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@Name", entity.Name)
                    );

                result = Convert.ToInt32(command.ExecuteScalar());

            }

            return result;

        }

        //public int UpdateGenre( Genre entity)
        //{
        //    var result = 0;
        //    using (IDbConnection cn
        //        = new SqlConnection(GetConnection()))
        //    {
        //        cn.Open();
        //        IDbCommand command =
        //            new SqlCommand("usp_UpdateGenre");
        //        command.Connection = cn;
        //        command.CommandType = CommandType.StoredProcedure;
        //        command.Parameters.Add(
        //            new SqlParameter("@Name", entity.Name)
        //            );

        //        result = Convert.ToInt32(command.ExecuteScalar());

        //    }
        //    return result;

        //}
    }
}
