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

        public bool UpdateCustomer(Customer entity)
        {
            var result = false;
            using (IDbConnection cn
                = new SqlConnection(GetConnection()))
            {
                cn.Query("usp_UpdateCustomer",
                    new
                    {
                        CustomerId = entity.CustomerId,
                        FirstName = entity.FirstName,
                        LastName = entity.LastName,
                        Company = entity.Company,
                        Address = entity.Address,
                        City = entity.City,
                        State = entity.State,
                        Country = entity.Country,
                        PostalCode = entity.PostalCode,
                        Phone = entity.Phone,
                        Fax = entity.Fax,
                        Email = entity.Email,
                        SupportRepId= entity.SupportRepId
                        
                    },
                        
                    commandType: CommandType.StoredProcedure);

                result = true;

            }
            return result;
        }

        public bool DeleteCustomer(Customer entity)
        {
            var result = false;
            using (IDbConnection cn
                = new SqlConnection(GetConnection()))
            {
                 cn.Query<int>("usp_DeleteCustomer",
                     new { FirstName = entity.FirstName },

                     commandType: CommandType.StoredProcedure);


            }
            //

            return result;
        }
    }
}
