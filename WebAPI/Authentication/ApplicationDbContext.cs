using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineShopDatabase.Models;

namespace WebAPI.Authentication
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {   
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<OnlineShopDatabase.Models.Category> Category { get; set; }

        public DbSet<OnlineShopDatabase.Models.Product> Product { get; set; }

        public DbSet<OnlineShopDatabase.Models.Cart> Cart { get; set; }

        public DbSet<OnlineShopDatabase.Models.OrderDetail> OrderDetail { get; set; }

        public DbSet<OnlineShopDatabase.Models.User> User { get; set; }
    }
}
