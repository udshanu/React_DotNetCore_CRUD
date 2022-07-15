using Microsoft.EntityFrameworkCore;
using React.Entities.Models;

namespace React.Entities.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        public DbSet<Owner> Owners { get; set; }
    }
}
