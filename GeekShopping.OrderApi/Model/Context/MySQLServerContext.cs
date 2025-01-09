using GeekShopping.OrderApi.Model;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.OrderApi.Model.Context
{
    public partial class MySQLServerContext : DbContext
    {
        public MySQLServerContext(DbContextOptions<MySQLServerContext> options) : base(options) {}

        public DbSet<OrderDetail> Details { get; set; }
        public DbSet<OrderHeader> Headers { get; set; }

    }
}
