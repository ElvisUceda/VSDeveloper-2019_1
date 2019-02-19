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
    public class AlbumDADapperTest
    {
        [TestMethod]
        public void GetCountTest()
        {
            var da = new AlbumDapperDA();

            Assert.IsTrue(da.GetCount() > 0);

        }

        [TestMethod]
        public void GetAlbumTest()
        {
            var da = new AlbumDapperDA();

            Assert.IsTrue(da.GetAlbum().Count > 0);

        }

        [TestMethod]
        public void GetAlbumByNameTest()
        {
            var da = new AlbumDapperDA();

            Assert.IsTrue(da.GetAlbum("a%").Count > 0);

        }

        [TestMethod]
        public void GetAlbumByNameWithSPTest()
        {
            var da = new AlbumDapperDA();
            Assert.IsTrue(da.GetAlbumWithSP("a%").Count > 0);
        }

        //[TestMethod]
        //public void InsertAlbumTest()
        //{
        //    var da = new AlbumDapperDA();
        //    var nuevoAlbum = da.InsertAlbum(
        //        new Album() { Title = "Nuevo Album" + Guid.NewGuid().ToString() });


        //    Assert.IsTrue(nuevoAlbum > 0);

        //}


        //[TestMethod]
        //public void UpdateAlbumTest()
        //{
        //    var da = new AlbumDapperDA();
        //    var actualizarAlbum = da.UpdateAlbum(
        //        new Album() { Title = "Actualiza Album" + Guid.NewGuid().ToString() });



        //}

        [TestMethod]
        public void DeleteAlbumTest()
        {
            var da = new AlbumDapperDA();
            var eliminaAlbum = da.DeleteAlbum(
                new Album() { Title = "Eliminar Album" + Guid.NewGuid().ToString() });



        }
    }
}
