using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>());
        // Look for any movies.
        if (context.Movie.Any())
        {
            return;   // DB has been seeded
        }
        context.Movie.AddRange(
            new Movie
            {
                Title = "The Other Side of Heaven",
                ReleaseDate = DateTime.Parse("2001-12-14"),
                Genre = "Adventure",
                Rating = "PG",
                Price = 7.99M,
                ImageName = "The Other Side of Heaven.jpg"
            },
            new Movie
            {
                Title = "17 Miracles",
                ReleaseDate = DateTime.Parse("2011-06-03"),
                Genre = "Adventure",
                Rating = "PG",
                Price = 7.99M,
                ImageName = "17 Miracles.jpg"
            },
            new Movie
            {
                Title = "The Work and the Glory",
                ReleaseDate = DateTime.Parse("2004-11-24"),
                Genre = "Drama",
                Rating = "PG",
                Price = 7.99M,
                ImageName = "The Work and the Glory.jpg"
            },
            new Movie
            {
                Title = "Saints and Soldiers",
                ReleaseDate = DateTime.Parse("2005-03-25"),
                Genre = "Action",
                Rating = "PG-13",
                Price = 7.99M,
                ImageName = "Saints and Soldiers.jpg"
            },
            new Movie
            {
                Title = "The Singles Ward",
                ReleaseDate = DateTime.Parse("2002-02-01"),
                Genre = "Comedy",
                Rating = "PG",
                Price = 7.99M,
                ImageName = "The Singles Ward.jpg"
            },
            new Movie
            {
                Title = "God's Army",
                ReleaseDate = DateTime.Parse("2000-03-10"),
                Genre = "Drama",
                Rating = "PG",
                Price = 7.99M,
                ImageName = "God's Army.jpg"
            },
            new Movie
            {
                Title = "The Testaments: Of One Fold and One Shepherd",
                ReleaseDate = DateTime.Parse("2000-03-30"),
                Genre = "Drama",
                Rating = "PG",
                Price = 7.99M,
                ImageName = "The Testaments Of One Fold and One Shepherd.jpg"
            },
            new Movie
            {
                Title = "Forever Strong",
                ReleaseDate = DateTime.Parse("2008-09-26"),
                Genre = "Drama",
                Rating = "PG-13",
                Price = 7.99M,
                ImageName = "Forever Strong.jpg"
            }
        );
        context.SaveChanges();
    }
}