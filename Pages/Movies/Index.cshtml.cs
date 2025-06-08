using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieHandle.Data;
using MovieHandle.Models;

namespace MovieHandle.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MovieHandle.Data.MovieHandleContext _context;

        public IndexModel(MovieHandle.Data.MovieHandleContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
