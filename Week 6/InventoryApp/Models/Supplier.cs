namespace InventoryApp.Models;

public class Supplier
{
    public int Id { get; set; }
    public required string Name { get; set; }
    // Foriegn Key
    public int AddressId { get; set; }
    // Navigation Property
    public required Address Address {get; set;}
    public required List<Product> Products { get; set; }
}