using System;
using MediatR;
using Persistence;

namespace Application.Movies.Commands;

public class DeleteMovie
{
    public class Command : IRequest
    {
        public required string Id { get; set; }
    }

    public class Handler(AppDbContext context) : IRequestHandler<Command>
    {
        public async Task Handle(Command request, CancellationToken cancellationToken)
        {
            var movie = await context.Movies.FindAsync([request.Id], cancellationToken)
                ?? throw new Exception("Movie not found.");

            context.Remove(movie);
            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
