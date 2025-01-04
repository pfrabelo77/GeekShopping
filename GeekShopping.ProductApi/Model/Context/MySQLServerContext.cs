using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GeekShopping.ProductApi.Model.Context
{
    public partial class MySQLServerContext : DbContext
    {
        public MySQLServerContext()
        {
        }

        public MySQLServerContext(DbContextOptions<MySQLServerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; } = null!;

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseMySql("server=localhost;database=geek_shopping_product_api;uid=root;pwd=admin7504", ServerVersion.Parse("8.0.40-mysql"));
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
//                .HasCharSet("utf8mb4");

//            modelBuilder.Entity<Product>(entity =>
//            {
//                entity.ToTable("product");

//                entity.HasCharSet("latin1")
//                    .UseCollation("latin1_swedish_ci");

//                entity.Property(e => e.Id).HasColumnName("ID");

//                entity.Property(e => e.CategoryName)
//                    .HasMaxLength(255)
//                    .HasColumnName("category_name");

//                entity.Property(e => e.Description)
//                    .HasMaxLength(255)
//                    .HasColumnName("description");

//                entity.Property(e => e.ImageUrl)
//                    .HasMaxLength(255)
//                    .HasColumnName("image_url");

//                entity.Property(e => e.Name)
//                    .HasMaxLength(255)
//                    .HasColumnName("name");

//                entity.Property(e => e.Price)
//                    .HasMaxLength(255)
//                    .HasColumnName("price");
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
