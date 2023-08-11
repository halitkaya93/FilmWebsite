using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmWebsite.Data.Entities
{
    public class FilmDBContext : DbContext
    {
        public FilmDBContext(DbContextOptions<FilmDBContext> options) : base(options)
        {
        }
        public DbSet<Film> Films { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
