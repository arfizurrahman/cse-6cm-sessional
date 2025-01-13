using InventoryApp.Data;
using InventoryApp.DTOs;
using InventoryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventoryApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase 
{
     private readonly AppDbContext _context;

     public ProductsController(AppDbContext context){
        _context = context;
     }

    [HttpGet]
    public IActionResult GetAll()
    {
        var products = _context.Products.ToList();
        return Ok(products);
    }
    
    // GET /api/Products/1
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        // SELECT * FROM Products WHERE ID = 1
        var product = _context.Products.Find(id);
        if(product == null) return NotFound();
        return Ok(product);
    }
    
    [HttpPost]
    public IActionResult Create(CreateProductDto productDto)
    {
        var product = new Product {
            Name = productDto.Name,
            Price = productDto.Price,
            Category = productDto.Category,
            Description =productDto.Description,
            Quantity = productDto.Quantity
        };

        _context.Products.Add(product);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetById), new {id = product.Id}, product);
    }

    // PUT /api/Products/1
    [HttpPut("{id}")]
    public IActionResult Update(int id, UpdateProductDto productDto)
    {
        var product = _context.Products.Find(id);
        if(product == null) return NotFound();

        product.Name = productDto.Name;
        product.Price = productDto.Price;
        product.Quantity = productDto.Quantity;
        product.Category = productDto.Category;
        product.Description = productDto.Description;

        // UPDATE query
        _context.SaveChanges();
        return NoContent();
    }

    // DELETE /api/Products/1
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
       var product = _context.Products.Find(id);
       if(product == null) return NotFound();

       _context.Products.Remove(product);
       // DELETE FROM Products WHERE Id = 1
       _context.SaveChanges();

       return NoContent();
    }
}