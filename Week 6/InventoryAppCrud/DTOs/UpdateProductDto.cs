namespace InventoryApp.DTOs;
public record UpdateProductDto(string Name, string Category, int Quantity, decimal Price, string Description);