namespace BugFreeBroccoli.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? Review { get; set; }
        public string? Genre { get; set; }
        public string? Franchise { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? TrailerUrl { get; set; }

    }
}