using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieApp.Data.Entities;

namespace MovieApp.Data.EntityConfigurations
{
    public class MovieLikeEntityTypeConfiguration : IEntityTypeConfiguration<MovieLike>
    {
        public void Configure(EntityTypeBuilder<MovieLike> builder)
        {
            builder.ToTable("MovieLikes");

            builder.HasKey(p => new { p.UserId, p.MovieId });
        }
    }
}
