using BillionnaireShoppingCart.Api.Db;
using BillionnaireShoppingCart.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace BillionnaireShoppingCart.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BillionnairesController : ControllerBase
{
    private readonly BillionnairesDb _db;

    public BillionnairesController(BillionnairesDb billionnairesDb)
    {
        _db = billionnairesDb;
    }
    [HttpGet]
    public List<Billionnaire> GetBillionnaires()
    {
        return _db.Data;
    }
}