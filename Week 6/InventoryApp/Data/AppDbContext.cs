using InventoryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}

    public required DbSet<Product> Products { get; set; }
    public required DbSet<Category> Categories { get; set; }
    public required DbSet<Address> Addresses { get; set; }
    public required DbSet<Supplier> Suppliers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>()
            .HasMany(p => p.Suppliers)
            .WithMany(s => s.Products)
            .UsingEntity(j => j.ToTable("ProductSuppliers"));
    }
}