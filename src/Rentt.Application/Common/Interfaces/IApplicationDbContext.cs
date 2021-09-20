using Microsoft.EntityFrameworkCore;
using Rentt.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Rentt.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Movie> Movies { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
