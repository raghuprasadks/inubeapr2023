using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cowin.Models
{
    public class CowinContext:DbContext
    {
        public CowinContext(DbContextOptions<CowinContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<State>().ToTable("State");
        }
        public DbSet<Users> users { get; set; }
        public DbSet<State> states { get; set; }


    }
}
