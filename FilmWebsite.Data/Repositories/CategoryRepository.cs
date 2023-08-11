using FilmWebsite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmWebsite.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IGenericRepository<Category> _repository;

        public CategoryRepository(IGenericRepository<Category> repository)
        {
            _repository = repository;
        }

        public void Create(Category entity)
        {
            _repository.Create(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Category> GetAll()
        {
            return _repository.GetAll();
        }

        public Category GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Save()
        {
            _repository.Save();
        }

        public void Update(Category entity)
        {
            _repository.Update(entity);
        }
    }
}
