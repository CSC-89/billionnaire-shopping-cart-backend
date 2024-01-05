using BillionnaireShoppingCart.Api.Models;

namespace BillionnaireShoppingCart.Api.Db;

public class ProductsDb : IDatabase<Product>
{
    public List<Product> Data { get; set; } = new()
    {
        new () {
            Name = "Beer 0.4L",
            Price = 64,
            ImagePath = "https://www.spendrups.se/ConvertedImages/19e78202-73ef-4d31-b9d8-8e6fdad8dca3.png?format=jpg"
        }
    };
}