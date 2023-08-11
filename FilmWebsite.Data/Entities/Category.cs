using System.ComponentModel.DataAnnotations;

namespace FilmWebsite.Data.Entities
{
    public class Category : BaseEntity
    {
        [StringLength(100)]
        public string? Name { get; set; }
        public string? Description { get; set; }

        public ICollection<Film> Films { get; set; }
    }
}
