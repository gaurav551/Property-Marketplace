using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nepalists.Models;
namespace Nepalists.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Listing> Listings {get;set;}
        public DbSet<Saved> Saves {get;set;}
        public DbSet<Profile> Profiles {get;set;}
        public DbSet<Follower> Followers {get;set;}
        public DbSet<Review> Reviews {get;set;}

    }
}
