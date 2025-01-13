namespace InventoryApp.Models;

public class Category
{
    public int Id { get; set; }
    public required string Name { get; set; }
    // Navigation Property
    public required List<Product> Products { get; set; }
}