namespace MovieApp.Data.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Image { get; set; } = null!;
        public int Like { get; set; }

        public ICollection<MovieLike> MovieLikes { get; set; } = null!;
    }
}
