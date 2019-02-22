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
    public class GenreDADapperTest
    {
        [TestMethod]
        public void InsertGenreTest()
        {
            var da = new GenreDapperDA();
            var nuevoGenero = da.InsertGenre(
                new Genre() { Name = "Nuevo Genero" + Guid.NewGuid().ToString() });

            Assert.IsTrue(nuevoGenero > 0);

        }

        [TestMethod]
        public void GetGenreTest()
        {
            var da = new GenreDapperDA();

            Assert.IsTrue(da.GetGenre().Count > 0);

        }

        [TestMethod]
        public void UpdateGenreTest()
        {
            var da = new GenreDapperDA();
            var actualizarGenero = da.UpdateGenre(
                new Genre() { Name = "Actualiza Genero" + Guid.NewGuid().ToString() });

            // Assert.IsTrue(actualizarGenero > 0);

        }

        [TestMethod]
        public void DeleteGenreTest()
        {
            var da = new GenreDA();
            var eliminaArtista = da.DeleteGenre(
                new Genre() { Name = "Eliminar Genero" + Guid.NewGuid().ToString() });

            // Assert.IsTrue(eliminaArtista > 0);

        }

    }


}
