using Microsoft.EntityFrameworkCore;
using Practical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical.Data
{
    public class PracticeContext:DbContext
    {
        public PracticeContext(DbContextOptions options):base(options) { }

        public DbSet<Products> product { get; set; }
    }
}
