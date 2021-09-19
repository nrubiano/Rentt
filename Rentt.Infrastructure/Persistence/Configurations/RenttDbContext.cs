using Microsoft.EntityFrameworkCore;
using Rentt.Domain.Entities;

namespace Rentt.Infrastructure.Persistence.Configurations
{
    public class RenttDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}
