using BillionnaireShoppingCart.Api.Db;
using Microsoft.AspNetCore.Mvc;

namespace BillionnaireShoppingCart.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IDatabase _db;

    public ProductsController(IDatabase productsDb)
    {
        _db = productsDb;
    }
    [HttpGet]
    public void GetBillionnaires()
    {
        throw new NotImplementedException();
    }
}