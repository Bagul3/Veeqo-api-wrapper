using System;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VeeqoRepository.Models
{
    public partial class VeeqoDevContext : DbContext
    {
        public VeeqoDevContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Orders> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\sqlexpress;Database=Veeqo-dev;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.Property(e => e.CutOffDate).HasColumnType("datetime");

                entity.Property(e => e.Deldate).HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasMaxLength(20);

                entity.Property(e => e.Orderdate).HasColumnType("datetime");

                entity.Property(e => e.Plu).HasColumnName("PLU");

                entity.Property(e => e.SuppColourRef).HasMaxLength(20);

                entity.Property(e => e.Tktprt).HasColumnName("tktprt");
            });
        }
    }
}
