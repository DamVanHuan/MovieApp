namespace MovieApp.Data.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Image { get; set; } = null!;
        public int Like { get; set; }
        public int Dislike { get; set; }

        public ICollection<MovieReaction> MovieReactions { get; set; } = null!;
    }
}
