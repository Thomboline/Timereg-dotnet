using Microsoft.EntityFrameworkCore;

namespace Vikarprojekt.Models
{

    public class VikarApiContext : DbContext
    {
        public VikarApiContext(DbContextOptions<VikarApiContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }

}