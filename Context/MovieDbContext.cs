
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using System.Diagnostics.CodeAnalysis;


namespace MovieApp.Context;



public class MovieDbContext : DbContext
{
    public MovieDbContext(DbContextOptions<MovieDbContext> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; } = default!;
}


