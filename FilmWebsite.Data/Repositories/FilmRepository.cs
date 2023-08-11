using FilmWebsite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmWebsite.Data.Repositories
{
    public class FilmRepository : IFilmRepository
    {
        private readonly IGenericRepository<Film> _genericRepository;

        public FilmRepository(IGenericRepository<Film> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public void Create(Film entity)
        {
            _genericRepository.Create(entity);
        }

        public void Delete(int id)
        {
            _genericRepository.Delete(id);
        }

        public List<Film> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public Film GetById(int id)
        {
            return _genericRepository.GetById(id);
        }

        public List<Film> GetFilmsByCategory(int categoryId)
        {
            return _genericRepository.GetAll().Where(x => x.CategoryId == categoryId).ToList();
        }

        public void Save()
        {
            _genericRepository.Save();
        }

        public void Update(Film entity)
        {
            _genericRepository.Update(entity);

        }
    }
}
