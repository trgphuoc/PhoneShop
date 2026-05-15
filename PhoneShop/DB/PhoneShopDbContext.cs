using Microsoft.EntityFrameworkCore;
using PhoneShop.Models;

namespace PhoneShop.DB
{
    public class PhoneShopDbContext : DbContext
    {
        public PhoneShopDbContext(DbContextOptions options) : base(options)
        {
        }

        protected PhoneShopDbContext()
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}