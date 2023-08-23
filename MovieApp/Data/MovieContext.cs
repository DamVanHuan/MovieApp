using Microsoft.EntityFrameworkCore;
using MovieApp.Commons;
using MovieApp.Data.Entities;
using MovieApp.Data.EntityConfigurations;

namespace MovieApp.Data
{
    public class MovieContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieReaction> MovieReactions { get; set; }

        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserEntityTypeConfiguration).Assembly);

            var uuid = Guid.NewGuid();
            modelBuilder.Entity<User>()
                .HasData(new User
                {
                    Id = 1,
                    Username = "user1",
                    Email = "user1@gmail.com",
                    Uid = uuid,
                    Password = LoginHelper.EncryptPassword("123456", uuid.ToString())
                });


            List<string> images = new List<string>
            {
                "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg",
                "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg",
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s",
                "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg"
            };
            List<Movie> movies = new List<Movie>();
            for (int i = 1; i <= 100; i++)
            {
                movies.Add(new Movie
                {
                    Id = i,
                    Title = $"Movie {i} title",
                    Image = images[(i - 1) % 4],
                    Like = 0,
                    Dislike = 0
                });
            }

            modelBuilder.Entity<Movie>()
                .HasData(movies);
        }
    }
}
