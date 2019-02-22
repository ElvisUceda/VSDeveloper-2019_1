using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chinook.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Chinook.Data.Test
{
    [TestClass]

    public class CustomerDADapperTest
    {
        [TestMethod]
        public void UpdateCustomerTest()
        {
            var da = new CustomerDapperDA();
            var actualizarAlbum = da.UpdateCustomer(
                new Customer() { FirstName = "Actualiza Customer" + Guid.NewGuid().ToString() });



        }


        //[TestMethod]
        //public void DeleteCustomerTest()
        //{
        //    var da = new CustomerDapperDA();
        //    var eliminaCustomer = da.DeleteCustomer(
        //        new Customer() { FirstName = "Eliminar Customer" + Guid.NewGuid().ToString() });
        //}
    }

}
