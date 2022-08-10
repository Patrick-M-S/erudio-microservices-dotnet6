using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(){}

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }
    
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Camiseta",
                Price = new decimal(69.9),
                Description = "m has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to mak",
                ImageURL = "https://images.pexels.com/photos/1844132/pexels-photo-1844132.jpeg?cs=srgb&dl=pexels-gabriela-pereira-1844132.jpg&fm=jpg",
                CategoryName = "T-shirt"
            });
        }
    }
}
