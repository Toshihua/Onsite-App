using Microsoft.EntityFrameworkCore;
using Onsite_App.Models.Entities;
using Microsoft.Identity.Client;

namespace Onsite_App.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
