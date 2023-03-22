﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
namespace Adventures.Data
{
    public class AdventureContext:IdentityDbContext<User>
    {
        public AdventureContext(DbContextOptions<AdventureContext> options)
            :base(options)
        {
        }
        //public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<SportActivity> SportActivities { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<EventReservation> EventReservations { get; set; }

    }
}
