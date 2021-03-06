﻿using App.DataAccess.Repository.Interface;
using App.EF.Entities.Query;
using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Repository
{
    public class TrackRepository
        : GenericRepository<Track>, ITrackRepository
    {
        public TrackRepository(DbContext context): base(context)
        {

        }
        public IEnumerable<TrackAll> GetTrackAll(string nombre)
        {
            return _context.Database.SqlQuery<TrackAll>
                 ("usp_GeTracks @TrackName",
                 new SqlParameter("TrackName", nombre)
            ).ToList();
        }
    }
}
