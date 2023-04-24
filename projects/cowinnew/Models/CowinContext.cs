using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cowinnew.Models
{
    public class CowinContext:DbContext
    {
        public CowinContext(DbContextOptions<CowinContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            
        }
        public DbSet<User> users { get; set; }

    }
}
