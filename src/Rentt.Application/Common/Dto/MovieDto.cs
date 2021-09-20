using Rentt.Application.Common.Mappings;
using Rentt.Domain.Entities;

namespace Rentt.Application.Common.Dto
{
    public class MovieDto : IMapFrom<Movie>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }
    }
}
