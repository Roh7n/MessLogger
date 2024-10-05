using MessLogger.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace MessLogger.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Visitor> Visitors { get; set; }
    }
}
