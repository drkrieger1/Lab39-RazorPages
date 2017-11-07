using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Lab39Erik.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab39Erik.Pages
{
    public class IndexModel : PageModel
    {
        private MovieContext _context;

        public IndexModel(MovieContext context) => _context = context;

        //public async Task OnGetAsync(string searchString)
        //{
        //    var movies = from m in _context.Movie
        //                 select m;

        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        movies = movies.Where(s => s.Title.Contains(searchString));
        //    }

        //     return movies
        //    //movies = await movies.ToListAsync();
        //}

    }
}
