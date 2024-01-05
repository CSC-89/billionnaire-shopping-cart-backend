using BillionnaireShoppingCart.Api.Models;

namespace BillionnaireShoppingCart.Api.Db;

public class ProductsDb : IDatabase<Product>
{
    public List<Product> Data { get; set; } = new()
    {
        new () {
            Name = "Test1",
            Price = 1000,
            ImagePath = "http://example.com"
        }
    };
}