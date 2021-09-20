using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rentt.Domain.Entities;

namespace Rentt.Infrastructure.Persistence.Configurations
{
    public class MoviesConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(t => t.Title)
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(t => t.Year)
                .IsRequired();
        }
    }
}
