using GeekShopping.CartAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.CartApi.Model.Context
{
    public partial class MySQLServerContext : DbContext
    {
        public MySQLServerContext(DbContextOptions<MySQLServerContext> options) : base(options) {}

        public DbSet<Product> Products { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<CartHeader> CartHeaders { get; set; }

    }
}
