using System;
using System.Collections.Generic;
using App.EF.CodeFirst.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace App.EF.CodeFirst.Test
{
    [TestClass]
    public class TrackDATest
    {
        [TestMethod]
        public void GetTracksByNameLinQ()
        {
            var da = new TrackDA();
            Assert.IsTrue(da.GetTrackByNameLinQ("Aero").Count() > 0);
        }

    }
}
