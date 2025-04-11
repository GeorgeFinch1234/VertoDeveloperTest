using Microsoft.EntityFrameworkCore;
namespace VertoDeveloperTest.Models
{
    public class iOTAContext : DbContext
    {
        public iOTAContext(DbContextOptions<iOTAContext> options) : base(options)
        {
        }

        public DbSet<Carousel> Carousels { get; set; }
    }
  
}
