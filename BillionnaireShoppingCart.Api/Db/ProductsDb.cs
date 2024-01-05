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
        },
        new () {
            Name = "HotDog",
            Price = 30,
            ImagePath = "https://storage.googleapis.com/mediabucketpb/1/2021/02/Korv_960x640px.jpg"
        },
        new () {
            Name = "Malmo FF",
            Price = 700600000,
            ImagePath = "https://www.mff.se/app/uploads/2019/03/190328_klubbskold-puff.jpg"
        },
        
    };
}