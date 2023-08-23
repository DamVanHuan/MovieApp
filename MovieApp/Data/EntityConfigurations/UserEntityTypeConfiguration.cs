using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieApp.Data.Entities;

namespace MovieApp.Data.EntityConfigurations
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            
            builder.HasKey(p =>  p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Username)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(p => p.Password)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Uid);
        }
    }
}
