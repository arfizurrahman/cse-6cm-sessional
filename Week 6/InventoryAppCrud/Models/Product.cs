using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryApp.Models;

public class Product {
    public int Id {get;set;}
    public required string Name { get; set; }    
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public required string Category { get; set; }
    [MaxLength(300)]
    public required string Description { get; set; }
}