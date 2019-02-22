using System;
using System.Collections.Generic;
using App.EF.CodeFirst;
using App.EF.CodeFirst.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App.EF.CodeFirst.test
{
    [TestClass]
    public class ArtistDATest
    {
        [TestMethod]
        public void Count()
        {
            var da = new ArtistDA();
           
            Assert.IsTrue(da.Count() > 0);

        }

        [TestMethod]
        public void Insert()
        {
            var da = new ArtistDA();
            var id = da.Insert(
                new Artist() { Name = "Artist_"
                    + Guid.NewGuid().ToString()
                }
                );

            Assert.IsTrue(id > 0);
        }

        [TestMethod]
        public void DeleteBatch()
        {
            var list = new List<int>();
            list.Add(292);
            list.Add(291);
            list.Add(290);
            var da = new ArtistDA();
            Assert.IsTrue(da.DeleteBatch(list));
          

            
        }

    }
}
