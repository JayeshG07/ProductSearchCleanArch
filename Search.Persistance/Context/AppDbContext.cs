using Microsoft.EntityFrameworkCore;
using Search.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Persistance.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> context) : base(context)
        {
        }

        public DbSet<Product> Products { get; set; }   
    }
}
