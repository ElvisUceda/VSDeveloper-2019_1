using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.DataAccess.Repository.Interface;

namespace App.DataAccess.Repository.Test
{
    
    [TestClass]
    public class AppUnitOfWorkTest
    {
        IAppUnitOfWorks unitOfWork;

        public AppUnitOfWorkTest()
        {

        }
        [TestMethod]
        public void ExiteArtistas()
        {
            using (var unitOfWork = new AppUnitOfWorks())
            {
                var canRows = unitOfWork.artistRepository.Count();

                unitOfWork.Complete();

                Assert.IsTrue(canRows > 0);

            }
        }
    }
}
