using System.Collections.Generic;
using BillionnaireShoppingCart.Api.Models;

namespace BillionnaireShoppingCart.Api.Db;

public class BillionnairesDb : IDatabase<Billionnaire>
{
    public List<Billionnaire> Data { get; set; } = new()
    {
        new () {
            Name = "Test1",
            NetWorth = 100000,
            ImagePath = "http://example.com"
        }
    };
}