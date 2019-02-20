using Chinook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using Dapper;

namespace Chinook.Data
{
   public class CustomerDapperDA:BaseConnection
    {
        //public int GetCount()
        //{
        //    var result = 0;

        //    var sql = "SELECT COUNT(1) FROM Customer";
        //    /*1: Create una instancia sql DbConnection*/
        //    using (IDbConnection cn = new SqlConnection(GetConnection()))
        //    {

        //        result = cn.Query<int>(sql).Single();

        //    }

        //    return result;
        //}

        //public List<Customer> GetCustomer()
        //{
        //    var result = new List<Customer>();
        //    var sql = "SELECT CustomerId,FirstName FROM Customer";
        //    using (IDbConnection cn = new SqlConnection(GetConnection()))
        //    {

        //        result = cn.Query<Customer>(sql).ToList();

        //    }

        //    return result;
        //}

        //public List<Customer> GetCustomer(string filterByName)
        //{
        //    var result = new List<Customer>();
        //    var sql = "SELECT CustomerId,FirstName FROM Customer WHERE Firstname like @firstname";
        //    using (IDbConnection cn = new SqlConnection(GetConnection()))
        //    {

        //        result = cn.Query<Customer>(sql
        //            , new { firstname = filterByName }).ToList();


        //    }

        //    return result;
        //}

        //public int InsertCustomer(Customer entity)
        //{
        //    var result = 0;
        //    using (IDbConnection cn
        //        = new SqlConnection(GetConnection()))
        //    {
        //        result = cn.Query<int>("usp_InsertCustomer",
        //             new { Name = entity.Name },

        //             commandType: CommandType.StoredProcedure).Single();


        //    }

        //    return result;

        //}
    }
}
