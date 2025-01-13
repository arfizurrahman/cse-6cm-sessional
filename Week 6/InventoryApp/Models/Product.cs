using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Models;

public class Product {
    public int Id {get;set;}
    public required string Name { get; set; }    
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    // [ForeignKey("CategoryId")]
    public int CategoryId { get; set; }
    // Navigation Property
    public required Category Category { get; set; }
    [MaxLength(300)]
    public required string Description { get; set; }

    public required List<Supplier> Suppliers { get; set; }
}