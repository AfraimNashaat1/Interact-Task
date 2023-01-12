using Microsoft.EntityFrameworkCore;
using ProductSearch.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSearch.DataAccessLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext([NotNullAttribute] DbContextOptions options): base(options) { }
     
        public DbSet<Product> Products { get; set; }
    }
}
