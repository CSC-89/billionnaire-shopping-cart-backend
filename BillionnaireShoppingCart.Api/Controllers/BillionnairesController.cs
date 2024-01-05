using BillionnaireShoppingCart.Api.Db;
using Microsoft.AspNetCore.Mvc;

namespace BillionnaireShoppingCart.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BillionnairesController : ControllerBase
{
    private readonly IDatabase _db;

    public BillionnairesController(IDatabase billionnaireDb)
    {
        _db = billionnaireDb;
    }
    [HttpGet]
    public void GetBillionnaires()
    {
        throw new NotImplementedException();
    }
}