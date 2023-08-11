using FilmWebsite.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmWebsite.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private FilmDBContext _context;
        private DbSet<T> _table;

        public GenericRepository(FilmDBContext context)
        {
            _context = context;
            _table = context.Set<T>();
        }
        public void Create(T entity)
        {

            _table.Add(entity);
        }

        public void Delete(int id)
        {
            T existing = _table.Find(id);
            _context.Remove(existing);
        }

        public List<T> GetAll()
        {
            return _table.ToList();
        }

        public T GetById(int id)
        {
            return _table.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
