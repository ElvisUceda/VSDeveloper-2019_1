using App.EF.CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EF.CodeFirst
{
    public class ArtistDA
    {
        private ChinookModel _context;

        public ArtistDA()
        {
            _context = new ChinookModel();
        }

        public int Count()
        {
            return _context.Artist.Count();
        }

        //Lista select * from artist where nombre like

        public IEnumerable<Artist> Gets(string filterByname)
        {
            return _context.Artist.Where(item => item.Name.Contains(filterByname)).ToList();
        }

        public Artist Get(int id)
        {
            return _context.Artist.Find(id);
        }

        public int Insert(Artist entity)
        {
            // Se agrega la entidad al contexto de Entity Framework
            _context.Artist.Add(entity);

            // Se confirma la Transacion
            _context.SaveChanges();

            return entity.ArtistId;

        }

        public bool Update(Artist entity)
        {
            // Se atacha la entidad al contexto de Entity Framework
            _context.Artist.Attach(entity);
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;

            // Se confirma la Transacion
           var result = _context.SaveChanges();

            return result > 0;

        }

        public bool Delete(Artist entity)
        {
            _context.Artist.Attach(entity);
            _context.Artist.Remove(entity);

            // Se confirma la Transaccion
            var result = _context.SaveChanges();

            return result > 0;
        }


        public bool DeleteBatch(List<int> ids)
        {
            foreach (var i in ids)
            {
                var entity = new Artist() { ArtistId = i };
                _context.Artist.Attach(entity);
                _context.Artist.Remove(entity);
            }
           

            // Se confirma la Transaccion
            var result = _context.SaveChanges();

            return result > 0;
        }
    }
}
