using System.ComponentModel.DataAnnotations;

namespace FilmWebsite.Data.Entities
{
    public class Film : BaseEntity
    {
        [StringLength(100)]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Director { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
