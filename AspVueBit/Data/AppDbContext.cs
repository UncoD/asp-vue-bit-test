using Microsoft.EntityFrameworkCore;

namespace AspVueBit.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<CameraParameters> CameraParameters { get; set; }
    }
}