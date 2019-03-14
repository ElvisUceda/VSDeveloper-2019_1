﻿using App.Services.WCF.Interfaces.Reportes;
using App.Domain;
using App.Domain.Interfaces;
using App.Entities.Base;
using App.Services.WCF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using App.Entities.Queries;

namespace App.Services.WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public partial class ReportesServices : IReportesServices
    {
        public IEnumerable<TrackAll> GetTrackAlls(string trackName)
        {
            TrackDomain domain = new TrackDomain();
           return domain.GetTrack(trackName);
        }
    }
}