using CVWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CVWebApp.Data
{
    public class GalleryDbContext : DbContext
    { 
        public GalleryDbContext(DbContextOptions<GalleryDbContext> opts) : base(opts) 
        { }
    
        public DbSet<Picture> Pictures { get; set; }
    }
}
