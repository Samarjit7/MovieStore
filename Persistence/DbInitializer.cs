using System;
using Domain;

namespace Persistence;

public class DbInitializer
{
    public static async Task SeedData(AppDbContext context)
    {
        if (context.Movies.Any()) return;

        var movies = new List<Movie>
        {
            new()
            {
                Title = "Inception",
                Director = "Christopher Nolan",
                Year = 2010
            },
            new()
            {
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Year = 1972
            },
            new()
            {
                Title = "Pulp Fiction",
                Director = "Quentin Tarantino",
                Year = 1994
            },
            new()
            {
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Year = 2008
            },
            new()
            {
                Title = "Schindler's List",
                Director = "Steven Spielberg",
                Year = 1993
            },
            new()
            {
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Year = 1994
            },
            new()
            {
                Title = "Fight Club",
                Director = "David Fincher",
                Year = 1999
            },
            new()
            {
                Title = "Forrest Gump",
                Director = "Robert Zemeckis",
                Year = 1994
            },
            new()
            {
                Title = "The Matrix",
                Director = "Lana Wachowski, Lilly Wachowski",
                Year = 1999
            },
            new()
            {
                Title = "Goodfellas",
                Director = "Martin Scorsese",
                Year = 1990
            },
            new()
            {
                Title = "The Lord of the Rings: The Fellowship of the Ring",
                Director = "Peter Jackson",
                Year = 2001
            },
            new()
            {
                Title = "Star Wars: Episode IV - A New Hope",
                Director = "George Lucas",
                Year = 1977
            },
            new()
            {
                Title = "The Silence of the Lambs",
                Director = "Jonathan Demme",
                Year = 1991
            },
            new()
            {
                Title = "Se7en",
                Director = "David Fincher",
                Year = 1995
            },
            new()
            {
                Title = "The Usual Suspects",
                Director = "Bryan Singer",
                Year = 1995
            },
            new()
            {
                Title = "Saving Private Ryan",
                Director = "Steven Spielberg",
                Year = 1998
            },
            new()
            {
                Title = "Interstellar",
                Director = "Christopher Nolan",
                Year = 2014
            },
            new()
            {
                Title = "Gladiator",
                Director = "Ridley Scott",
                Year = 2000
            },
            new()
            {
                Title = "The Green Mile",
                Director = "Frank Darabont",
                Year = 1999
            },
            new()
            {
                Title = "Braveheart",
                Director = "Mel Gibson",
                Year = 1995
            },
            new()
            {
                Title = "The Departed",
                Director = "Martin Scorsese",
                Year = 2006
            },
            new()
            {
                Title = "The Prestige",
                Director = "Christopher Nolan",
                Year = 2006
            },
            new()
            {
                Title = "Memento",
                Director = "Christopher Nolan",
                Year = 2000
            },
            new()
            {
                Title = "The Lion King",
                Director = "Roger Allers, Rob Minkoff",
                Year = 1994
            },
            new()
            {
                Title = "Titanic",
                Director = "James Cameron",
                Year = 1997
            }
        };

        context.Movies.AddRange(movies);
        await context.SaveChangesAsync();
    }
}