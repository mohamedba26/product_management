using Microsoft.EntityFrameworkCore;

namespace chaabene.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Archieve> Archieves { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<OfferDetail> OfferDetails{ get; set; }
    }
}
