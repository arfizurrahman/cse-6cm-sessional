namespace InventoryApp.DTOs;
public record CreateProductDto(string Name, string Category, int Quantity, decimal Price, string Description);