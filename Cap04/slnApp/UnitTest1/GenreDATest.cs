using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.EF.CodeFirst.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App.EF.CodeFirst.Test
{
    [TestClass]
    public class GenreDATest
    {
        [TestMethod]
        public void Count()
        {
            var da = new GenreDA();
            Assert.IsTrue(da.Count() > 0);
        }
        [TestMethod]
        public void Insert()
        {
            var da = new GenreDA();
            var id = da.Insert(
                new Genre()
                {
                    Name = "Genre_"
                            + Guid.NewGuid().ToString()
                }
                );

            Assert.IsTrue(id > 0);

        }

        [TestMethod]
        public void DeleteBatch()
        {
            var list = new List<int>();
            list.Add(27);
            list.Add(28);
            list.Add(29);
            var da = new GenreDA();
            Assert.IsTrue(da.DeleteBatch(list));
        }
    }
}
