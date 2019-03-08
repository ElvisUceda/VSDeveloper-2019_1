using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.DataAccess.Repository.Interface;
using App.Entities.Base;

namespace App.DataAccess.Repository
{
    public class AlbumRepository: GenericRepository<Album>, IAlbumRepository
    {
        public AlbumRepository(DbContext context) : base(context)
        {

        }
    }
}
