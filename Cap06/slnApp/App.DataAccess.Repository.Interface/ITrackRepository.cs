﻿using App.EF.Entities.Query;
using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Repository.Interface
{
    public interface ITrackRepository
        :IGenericRepository<Track>
    {        
        IEnumerable<TrackAll> GetTrackAll(string nombre);
    }
}
