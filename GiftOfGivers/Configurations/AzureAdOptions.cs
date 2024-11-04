namespace GiftOfGivers.Configurations
{
    // Data/ApplicationDbContext.cs
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GiftOfGivers.Models;
using System.Collections.Generic;


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Incident> Incidents { get; set; }
        public DbSet<Donation> Donations { get; set; }
    }
}