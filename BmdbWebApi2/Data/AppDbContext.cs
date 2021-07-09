using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BmdbWebApi2.Models;

namespace BmdbWebApi2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<BmdbWebApi2.Models.Actors> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MovieCollection> MovieCollections { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
    }
}
