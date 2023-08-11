namespace FilmWebsite.Model
{
    public class AddFilmModel
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Director { get; set; }

        public int CategoryId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
