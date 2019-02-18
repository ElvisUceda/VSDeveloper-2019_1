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
        public void GetArlbumByNameTest()
        {
            var da = new AlbumDapperDA();

            Assert.IsTrue(da.GetAlbum("a%").Count > 0);

        }

    }
}
