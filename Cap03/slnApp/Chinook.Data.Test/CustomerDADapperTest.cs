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
        public void InsertCustomerTest()
        {
            var da = new CustomerDapperDA();
            var nuevoCustomer = da.InsertCustomer(
                new Customer() {
                                SupportRepId = 1,
                                FirstName = "Elvis ",
                                 LastName ="Uceda ",
                                Company = "Lira",
                                Address = "Lima",
                                City = "Lima",
                                Country = "Peru",
                                PostalCode = "051",
                                Phone = "999999999",
                                Fax = "0547897",
                                Email = "xfg@peru.com"
                               
                                + Guid.NewGuid().ToString() });


            Assert.IsTrue(nuevoCustomer > 0);

        }

        [TestMethod]
        public void UpdateCustomerTest()
        {
            var da = new CustomerDapperDA();
            var actualizarAlbum = da.UpdateCustomer(
                new Customer() { FirstName = "Actualiza Customer" + Guid.NewGuid().ToString() });



        }


        [TestMethod]
        public void DeleteCustomerTest()
        {
            var da = new CustomerDapperDA();
            var eliminaCustomer = da.DeleteCustomer(
                new Customer() { FirstName = "Eliminar Customer" + Guid.NewGuid().ToString() });
        }
    }

}
