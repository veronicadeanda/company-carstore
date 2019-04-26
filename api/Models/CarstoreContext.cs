using Microsoft.EntityFrameworkCore;

namespace Company.Carstore.Api.Models
{
    public class CarstoreContext : DbContext
    {
        public CarstoreContext(DbContextOptions<CarstoreContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder) => base.OnModelCreating(builder);
        public DbSet<Car> Cars { get; set; }
    }
}