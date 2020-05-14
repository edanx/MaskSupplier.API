using MaskSupplier.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MaskSupplier.Infra.Context
{
    public class MaskSupplierContext : DbContext
    {
        public MaskSupplierContext(DbContextOptions<MaskSupplierContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Mask>(entity =>
            {
                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Masks)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
            
            
            modelBuilder.Entity<City>(entity =>
            {
                entity.HasMany(d => d.Suppliers)
                    .WithOne(p => p.City)
                    .OnDelete(DeleteBehavior.Cascade);
            });
            
            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasOne(d => d.City)
                    .WithMany(p => p.Suppliers);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasMany(d => d.Masks)
                    .WithOne(p => p.Supplier)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }

        public DbSet<Mask> Mask { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
    }
}

