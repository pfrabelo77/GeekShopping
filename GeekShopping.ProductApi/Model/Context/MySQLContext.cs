using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace GeekShopping.ProductApi.Model.Context
{
    public class MySQLServerContext : DbContext
    {
        public MySQLServerContext() { }
        public MySQLServerContext(DbContextOptions<MySQLServerContext> options) : base(options) { }


        public DbSet<Product> Products { get; set; }


    }
}
