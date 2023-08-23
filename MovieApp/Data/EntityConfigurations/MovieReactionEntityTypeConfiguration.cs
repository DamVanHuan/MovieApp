using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieApp.Data.Entities;

namespace MovieApp.Data.EntityConfigurations
{
    public class MovieReactionEntityTypeConfiguration : IEntityTypeConfiguration<MovieReaction>
    {
        public void Configure(EntityTypeBuilder<MovieReaction> builder)
        {
            builder.ToTable("MovieReactions");

            builder.HasKey(p => new { p.UserId, p.MovieId });

            builder.Property(p => p.Liked);

            builder.Property(p => p.DisLiked);
        }
    }
}
