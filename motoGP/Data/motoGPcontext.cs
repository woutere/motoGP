using Microsoft.EntityFrameworkCore;
using motoGP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motoGP.Data
{
    public class motoGPcontext:DbContext
    {
        public motoGPcontext(DbContextOptions<motoGPcontext> options)
            : base(options)
        {

        }
        public DbSet<Team> teams { get; set; }
        public DbSet<Rider> riders { get; set; }
        public DbSet<Race> races { get; set; }
        public DbSet<Ticket> tickets { get; set; }
        public DbSet<Country> countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().ToTable("Team");
            modelBuilder.Entity<Rider>().ToTable("Rider");
            modelBuilder.Entity<Race>().ToTable("Race");
            modelBuilder.Entity<Ticket>().ToTable("Ticket");
            modelBuilder.Entity<Country>().ToTable("Country");
        }
    }
}
