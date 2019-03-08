 using App.DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Repository
{
    public class AppUnitOfWorks : IAppUnitOfWorks
    {

        private readonly DbContext _context;

        public AppUnitOfWorks()
        {
            _context = new AppDataModel();
            CreatedReposotories();
        }

        public AppUnitOfWorks(DbContext context)
        {
            _context = context;
            CreatedReposotories();
        }

        private void CreatedReposotories()
        {
            this.artistRepository = new ArtistRepository(_context);
            this.trackRepository = new TrackRepository(_context);
        }

        public IArtistRepository artistRepository { get; set; }
        public ITrackRepository trackRepository { get; set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
