using System;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Movies.Commands;

public class EditMovie
{
    public class Command : IRequest
    {
        public required Movie Movie { get; set; }
    }

    public class Handler(AppDbContext context, IMapper mapper) : IRequestHandler<Command>
    {
        public async Task Handle(Command request, CancellationToken cancellationToken)
        {
            var movie = await context.Movies.FindAsync([request.Movie.Id], cancellationToken)
                ?? throw new Exception("Movie not found.");

            mapper.Map(request.Movie, movie);
            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
