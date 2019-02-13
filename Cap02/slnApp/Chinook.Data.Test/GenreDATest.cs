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
    public class GenreDATest
    {
        [TestMethod]
        public void InsertGenreTest()
        {
            var da = new GenreDA();
            var nuevoGenero = da.InsertGenre(
                new Genre() { Name = "Nuevo Genero" + Guid.NewGuid().ToString() });

            Assert.IsTrue(nuevoGenero > 0);

        }

    }
}
