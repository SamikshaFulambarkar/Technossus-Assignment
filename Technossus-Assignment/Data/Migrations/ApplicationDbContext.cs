using Microsoft.EntityFrameworkCore;
using Technossus_Assignment.Models;

namespace Technossus_Assignment
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Students> students { get; set; }
        public DbSet<SoftDeletes> softDeletes { get; set; }
    }
}

