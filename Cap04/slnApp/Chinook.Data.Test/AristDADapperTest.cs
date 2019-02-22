﻿using System;
using Chinook.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chinook.Data.Test
{
    [TestClass]
    public class ArtisDaDApperTest
    {
        [TestMethod]
        public void GetCountTest()
        {
            var da = new ArtistDapperDA();

            Assert.IsTrue(da.GetCount() > 0);

        }

        [TestMethod]
        public void GetArtistTest()
        {
            var da = new ArtistDapperDA();

            Assert.IsTrue(da.GetArtists().Count > 0);

        }

        [TestMethod]
        public void GetArtistByNameTest()
        {
            var da = new ArtistDA();

            Assert.IsTrue(da.GetArtists("a%").Count > 0);

        }

        [TestMethod]
        public void InsertArtistTest()
        {
            var da = new ArtistDapperDA();
            var nuevoArtista = da.InsertArtist(
                new Artist() { Name = "Nuevo Artista" + Guid.NewGuid().ToString() });

            Assert.IsTrue(nuevoArtista > 0);

        }

        [TestMethod]
        public void InsertArtistWithOutputParamTest()
        {
            var da = new ArtistDapperDA();
            var nuevoArtista = da.InsertArtistWithOutput(
                new Artist() { Name = "Nuevo Artista" + Guid.NewGuid().ToString() });

            Assert.IsTrue(nuevoArtista > 0);

        }

        [TestMethod]
        public void InsertArtistWithTXTest()
        {
            var da = new ArtistDapperDA();
            var nuevoArtista = da.InsertArtistWithTX(
                new Artist() { Name = "Nuevo Artista" + Guid.NewGuid().ToString() });

            Assert.IsTrue(nuevoArtista > 0);

        }

        // Actualizar Artist

        [TestMethod]
        public void UpdateArtistTest()
        {
            var da = new ArtistDA();
            var actualizarArtista = da.UpdateArtist(
                new Artist() { Name = "Actualiza Artista" + Guid.NewGuid().ToString() });

           

        }

        // Eliminar Artist

        [TestMethod]
        public void DeleteArtistTest()
        {
            var da = new ArtistDA();
            var eliminaArtista = da.DeleteArtist(
                new Artist() { Name = "Eliminar Artista" + Guid.NewGuid().ToString() });

          

        }
        [TestMethod]
        public void InsertArtistWithTXTestDist()
        {
            var da = new ArtistDapperDA();
           
            var nuevoArtista = da.InsertArtistWithTXDist(
                new Artist() { Name = "Nuevo Artista" + Guid.NewGuid().ToString() });

            Assert.IsTrue(nuevoArtista > 0);

        }

        [TestMethod]
        public void GetArtistByNameWithSPTest()
        {
            var da = new ArtistDapperDA();
            Assert.IsTrue(da.GetArtisWithSP("a%").Count > 0);



        }


    }
}
