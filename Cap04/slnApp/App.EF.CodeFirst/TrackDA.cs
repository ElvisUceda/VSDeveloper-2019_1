﻿using App.EF.Entities.Query;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EF.CodeFirst
{
    public class TrackDA
    {
        private ChinookModel _context;

        public TrackDA()
        {
            _context = new ChinookModel();
        }

        public IEnumerable<TrackConsulta> GetTrackByName(string name)
        {
            name = !string.IsNullOrWhiteSpace(name)? $"%{name}%" : "%";
            return _context.Database
                .SqlQuery<TrackConsulta>("usp_GetTrack @name",
                new SqlParameter("@name",name)
                ).ToList();

        }
    }
}
