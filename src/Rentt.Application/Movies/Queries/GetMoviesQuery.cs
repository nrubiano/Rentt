using AutoMapper;
using MediatR;
using Rentt.Application.Common.Dto;
using Rentt.Application.Common.Interfaces;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace Rentt.Application.Movies.Queries
{
    public class GetMoviesQuery : IRequest<IList<MovieDto>>
    {
        
    }

    public class GetMoviesQueryHandler : IRequestHandler<GetMoviesQuery, IList<MovieDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetMoviesQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _context = dbContext;
            _mapper = mapper;
        }

        public async Task<IList<MovieDto>> Handle(GetMoviesQuery request, CancellationToken cancellationToken)
        {
            return await _context
                .Movies
                .OrderBy(x => x.Title)
                .ProjectTo<MovieDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
