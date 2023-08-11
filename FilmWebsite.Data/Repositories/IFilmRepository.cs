using FilmWebsite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmWebsite.Data.Repositories
{
    public interface IFilmRepository : IGenericRepository<Film>
    {
        List<Film> GetFilmsByCategory(int categoryId);
    }
}
