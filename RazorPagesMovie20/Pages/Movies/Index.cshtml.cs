using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie20.Data;
using RazorPagesMovie20.Models;

namespace RazorPagesMovie20.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie20.Data.RazorPagesMovie20Context _context;

        public IndexModel(RazorPagesMovie20.Data.RazorPagesMovie20Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
