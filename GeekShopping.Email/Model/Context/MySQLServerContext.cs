using Microsoft.EntityFrameworkCore;

namespace GeekShopping.Email.Model.Context
{
    public partial class MySQLServerContext : DbContext
    {
        public MySQLServerContext(DbContextOptions<MySQLServerContext> options) : base(options) {}

        public DbSet<EmailLog> Emails { get; set; }

    }
}
