using trackerDotnet.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace trackerDotnet.Models.Data
{
    public class TrackerContext : DbContext
    {
        // Tables
        public DbSet<User> Users { get; set; }
        public DbSet<Sighting> Sightings { get; set; }

        public TrackerContext([NotNullAttribute] DbContextOptions options) : base(options)
        {

        }

        //
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(new User { Id = 1, Name = "Erik", Email = "erik.kvalvik@gmail.com" });

            modelBuilder.Entity<Sighting>().HasData(new Sighting { Id = 1, Animal = "Moose", LastUpdated = DateTime.UtcNow, Latitude = 1, Longitude = 1, SenderId = 1});
        }
    }
}


