using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using App.Entities.Queries;

namespace App.Services.WCF.Interfaces.Reportes
{
  
    public partial interface IReportesServices
    {
        [OperationContract]
         IEnumerable<TrackAll> GetTrackAlls(string trackName);
    }
}
