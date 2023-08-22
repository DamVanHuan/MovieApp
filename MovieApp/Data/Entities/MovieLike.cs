namespace MovieApp.Data.Entities
{
    public class MovieLike
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }

        public User User { get; set; } = null!;
        public Movie Movie { get; set; } = null!;
    }
}
