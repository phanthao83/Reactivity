using Microsoft.EntityFrameworkCore;
using System;
using Domain; 

namespace Persistence
{
    public class DataContext: DbContext

    {
        public DataContext(DbContextOptions<DataContext> options)
           : base(options)
        {
        }

        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
                .HasData(
                new Value { Id = 1, Text = "Value 101" },
                 new Value { Id = 2, Text = "Value 102" },
                  new Value { Id = 3, Text = "Value 103" }


                );
        }
    }
}
