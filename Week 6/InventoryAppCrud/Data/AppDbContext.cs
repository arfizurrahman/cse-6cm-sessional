using InventoryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}

    public required DbSet<Product> Products { get; set; }
}