using App.EF.CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EF.CodeFirst
{
    public class GenreDA
    {
        private ChinookModel _context;

        public GenreDA()
        {
            _context = new ChinookModel();
        }

        public int Count()
        {
            return _context.Genre.Count();
        }

        public IEnumerable<Genre> Gets(string filterByName)
        {
            return _context.Genre.Where(item => item.Name.Contains(filterByName)).ToList();
        }
        public Genre Get(int id)
        {
            return _context.Genre.Find(id);
        }

        public int Insert(Genre entity)
        {
            //Se agrega la entidad al contexto de Entity Framework
            _context.Genre.Add(entity);

            //Se confirma la transaccion
            _context.SaveChanges();

            return entity.GenreId;

        }

        public bool Update(Genre entity)
        {
            //Se atacha la entidad al contexto de Entity Framework
            _context.Genre.Attach(entity);
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;

            //Se confirma la transaccion
            var result = _context.SaveChanges();

            return result > 0;

        }

        public bool Delete(Genre entity)
        {
            _context.Genre.Attach(entity);
            _context.Genre.Remove(entity);

            //Se confirma la transaccion
            var result = _context.SaveChanges();

            return result > 0;
        }

        public bool DeleteBatch(List<int> ids)
        {
            foreach (var i in ids)
            {
                var entity = new Genre() { GenreId = i };
                _context.Genre.Attach(entity);
                _context.Genre.Remove(entity);
            }
            //Se confirma la transaccion
            var result = _context.SaveChanges();

            return result > 0;
        }

    }
}
