using Microsoft.EntityFrameworkCore;

namespace assignment9.Models
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options)
            : base(options)
        {
             this.Database.EnsureCreated();
        }
        public DbSet<Order> order { get; set; }
    }
}