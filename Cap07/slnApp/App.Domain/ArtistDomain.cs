//using App.DataAccess.Repository.Interface;
using App.Domain.Interfaces;
using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain
{
    public class ArtistDomain : IArtistDomain
    {
        public IEnumerable<Artist> GetArtists()
        {
            IEnumerable<Artist> result = new List<Artist>()
           using (var uw = new IAppUnitOfWorks()
            {
                result = uw.ArtistRepository.GetAll();
            }
            return result;
        }
    }
}
