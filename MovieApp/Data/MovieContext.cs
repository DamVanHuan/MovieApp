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

            modelBuilder.Entity<Movie>()
                .HasData(
                new Movie
                {
                    Id = 1,
                    Title = "Movie 1 title",
                    Image = "https://images.freeimages.com/images/previews/5eb/movie-clapboard-1184339.jpg"
                }, 
                new Movie
                {
                    Id = 2,
                    Title = "Movie 2 title",
                    Image = "https://st3.depositphotos.com/1064045/15061/i/450/depositphotos_150614902-stock-photo-unusual-cinema-concept-3d-illustration.jpg"
                },
                new Movie
                {
                 Id = 3,
                    Title = "Movie 3 title",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC1pJ0eoHXdlJEVeVY0MlJ2kUOYrLHGvpY7yIHl2E4&s"
                },
                new Movie{
                    Id = 4,
                    Title = "Movie 4 title",
                    Image = "https://www.shutterstock.com/shutterstock/photos/586719869/display_1500/stock-vector-online-cinema-art-movie-watching-with-popcorn-and-film-strip-cinematograph-concept-vintage-retro-586719869.jpg"
                });
        }
    }
}
