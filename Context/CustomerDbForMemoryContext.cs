using Microsoft.EntityFrameworkCore;
using PercipoBookChapter11.Models;
using System.Collections.Generic;

namespace PercipoBookChapter11.Context
{
    public class CustomerDbForMemoryContext : DbContext
    {
        public CustomerDbForMemoryContext(DbContextOptions<CustomerDbContext> options)
            : base(options) { }

        public DbSet<CustomerForMemory> Customers { get; set; }
    }

}
