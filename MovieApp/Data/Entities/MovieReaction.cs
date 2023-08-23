namespace MovieApp.Data.Entities
{
    public class MovieReaction
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }

        public bool Liked { get; set; }
        public bool Disliked { get; set; }

        public User User { get; set; } = null!;
        public Movie Movie { get; set; } = null!;
    }
}
