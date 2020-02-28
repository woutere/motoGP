using Microsoft.EntityFrameworkCore;
using motoGP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motoGP.Data
{
    public class MotoGPcontext:DbContext
    {
        public MotoGPcontext(DbContextOptions<MotoGPcontext> options)
            : base(options)
        {

        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Rider> Riders { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Country> Countries { get; set; }

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
