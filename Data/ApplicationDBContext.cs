using Microsoft.EntityFrameworkCore;
using food_asp.Models;
namespace food_asp.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Customer> tb_Customers { get; set; }

        public DbSet<Product> tb_Product { get; set; }

        public DbSet<Admin> tb_Admin { get; set; }

        public DbSet<Order> tb_Order { get; set; }

        public DbSet<OrderDetail> tb_OrderDetail { get; set; }
    }
}
