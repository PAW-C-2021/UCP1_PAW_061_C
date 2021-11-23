using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace OnlineShopp.Models
{
    public partial class OnlineShoppContext : DbContext
    {
        public OnlineShoppContext()
        {
        }

        public OnlineShoppContext(DbContextOptions<OnlineShoppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Konsuman> Konsumen { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Produk> Produks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.IdAdmin);

                entity.ToTable("Admin");

                entity.Property(e => e.IdAdmin)
                    .ValueGeneratedNever()
                    .HasColumnName("id_admin");

                entity.Property(e => e.Alamat)
                    .HasMaxLength(150)
                    .HasColumnName("alamat");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .HasColumnName("gender");

                entity.Property(e => e.Nama)
                    .HasMaxLength(50)
                    .HasColumnName("nama");
            });

            modelBuilder.Entity<Konsuman>(entity =>
            {
                entity.HasKey(e => e.IdKonsumen);

                entity.Property(e => e.IdKonsumen)
                    .ValueGeneratedNever()
                    .HasColumnName("id_konsumen");

                entity.Property(e => e.Alamat)
                    .HasMaxLength(150)
                    .HasColumnName("alamat");

                entity.Property(e => e.NamaKonsumen)
                    .HasMaxLength(50)
                    .HasColumnName("nama_konsumen");

                entity.Property(e => e.NoHp)
                    .HasMaxLength(12)
                    .HasColumnName("no_hp");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.IdLogin);

                entity.ToTable("Login");

                entity.Property(e => e.IdLogin)
                    .ValueGeneratedNever()
                    .HasColumnName("id_login");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Info)
                    .HasMaxLength(50)
                    .HasColumnName("info");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<Produk>(entity =>
            {
                entity.HasKey(e => e.IdProduk);

                entity.ToTable("Produk");

                entity.Property(e => e.IdProduk)
                    .ValueGeneratedNever()
                    .HasColumnName("id_produk");

                entity.Property(e => e.NamaProduk)
                    .HasMaxLength(50)
                    .HasColumnName("nama_produk");

                entity.Property(e => e.Quantity)
                    .HasMaxLength(50)
                    .HasColumnName("quantity");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
