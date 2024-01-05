using BillionnaireShoppingCart.Api.Db;
using BillionnaireShoppingCart.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace BillionnaireShoppingCart.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ProductsDb _db;

    public ProductsController(ProductsDb productsDb)
    {
        _db = productsDb;
    }
    [HttpGet]
    public List<Product> GetAllProducts()
    {
        return _db.Data;
    }
}