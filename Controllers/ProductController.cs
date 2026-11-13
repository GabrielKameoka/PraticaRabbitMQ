using Microsoft.AspNetCore.Mvc;
using PraticaRabbitMQ.Models;

namespace PraticaRabbitMQ.Controllers;

[ApiController]
[Route("api/products")]
public sealed class ProductController : ControllerBase
{
    private static readonly List<Product> Products = [];
    private static int _nextId = 1;

    [HttpGet]
    public ActionResult<IReadOnlyList<Product>> GetAll() => Ok(Products);

    [HttpPost]
    public ActionResult<Product> Create(CreateProductRequest request)
    {
        var product = new Product(_nextId++, request.Name.Trim(), request.Price);
        Products.Add(product);
        return Created($"/api/products/{product.Id}", product);
    }

    public sealed record CreateProductRequest(string Name, decimal Price);
}
