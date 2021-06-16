using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie20.Models;

namespace RazorPagesMovie20.Data
{
    public class RazorPagesMovie20Context : DbContext
    {
        public RazorPagesMovie20Context (DbContextOptions<RazorPagesMovie20Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie20.Models.Movie> Movie { get; set; }
    }
}
