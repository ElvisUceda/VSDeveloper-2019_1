using System;
using System.Text;
using App.DataAccess.Repository.Interface;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Data.Entity;

namespace App.DataAccess.Repository.Test
{

    [TestClass]
    public class TrackRepositoryTest
    {
        private readonly DbContext _context;
        public TrackRepositoryTest()
        {
            _context = new AppDataModel();
        }
        [TestMethod]
        public void GetAll()
        {
            ITrackRepository repository = new TrackRepository(_context);
            var entities = repository.GetTrackAll("%aero%");
               

            Assert.IsTrue(entities.Count() > 0);
        }
    }
}
