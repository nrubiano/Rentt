using Microsoft.EntityFrameworkCore;
using Rentt.Application.Common.Interfaces;
using Rentt.Domain.Entities;

namespace Rentt.Infrastructure.Persistence
{
    public class RenttDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public RenttDbContext(DbContextOptions<RenttDbContext> options)
        : base(options)
        {
        }
    }
}
