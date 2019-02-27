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

        //[TestMethod]
        //public void DeleteBatch()
        //{
        //    var list = new List<int>();
        //    list.Add(294);
        //    list.Add(295);
        //    list.Add(296);
        //    var da = new ArtistDA();
        //    Assert.IsTrue(da.DeleteBatch(list));
          

            
        //}

    }
}
