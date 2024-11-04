using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Azure.Documents;
using Microsoft.EntityFrameworkCore;

namespace GiftOfGivers.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }

}
