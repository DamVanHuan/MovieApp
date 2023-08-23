namespace MovieApp.DTOs.Movies
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
    }
}
