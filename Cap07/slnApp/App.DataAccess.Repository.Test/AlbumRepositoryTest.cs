using System;
using System.Data.Entity;
using System.Linq;
using App.DataAccess.Repository.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App.DataAccess.Repository.Test
{
    [TestClass]
    public class AlbumRepositoryTest
    {

        private readonly DbContext _context;

        public AlbumRepositoryTest()
        {
            _context = new AppDataModel();
        }
        [TestMethod]
        public void Count()
        {

            IAlbumRepository repository = new AlbumRepository(_context);
            int count = repository.Count();

            Assert.IsTrue(count > 0);
        }

        [TestMethod]
        public void GetAll()
        {
            IArtistRepository repository = new ArtistRepository(_context);
            var data = repository.GetAll(item => item.Name.Contains("Aero")
                , item => item.OrderBy(item2 => item2.Name));

            Assert.IsTrue(data.Count() > 0);
        }
    }
}
