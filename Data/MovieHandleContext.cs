using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieHandle.Models;

namespace MovieHandle.Data
{
    public class MovieHandleContext : DbContext
    {
        public MovieHandleContext (DbContextOptions<MovieHandleContext> options)
            : base(options)
        {
        }

        public DbSet<MovieHandle.Models.Movie> Movie { get; set; } = default!;
    }
}
