using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chinook.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chinook.Data.Test
{
    public class AlbumDADapperTest
    {
        [TestMethod]
        public void GetCountTest()
        {
            var da = new AlbumDapperDA();

            Assert.IsTrue(da.GetCount() > 0);

        }
    }
}
