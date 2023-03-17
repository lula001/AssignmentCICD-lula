using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Auckland_Institute_of_Studies.Models;

namespace Auckland_Institute_of_Studies.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Auckland_Institute_of_Studies.Models.Product> Product { get; set; } = default!;
    }
}