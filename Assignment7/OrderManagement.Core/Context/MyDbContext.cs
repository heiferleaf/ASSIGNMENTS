using Microsoft.EntityFrameworkCore;
using HW7.Core.Model;

namespace HW7.Core.Context
{
    public class MyDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasKey(o => o.OrderId);

            modelBuilder.Entity<Order>()
                .OwnsOne(o => o.OrderDetails);
        }
    }
}