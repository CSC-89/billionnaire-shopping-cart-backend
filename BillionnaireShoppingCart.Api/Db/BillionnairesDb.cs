using System.Collections.Generic;
using BillionnaireShoppingCart.Api.Models;

namespace BillionnaireShoppingCart.Api.Db;

public class BillionnairesDb : IDatabase<Billionnaire>
{
    public List<Billionnaire> Data { get; set; } = new()
    {
        new () {
            Name = "Elon Musk",
            NetWorth = 251000000000,
            ImagePath = "https://imageio.forbes.com/specials-images/imageserve/62d700cd6094d2c180f269b9/0x0.jpg?format=jpg&crop=959,959,x0,y0,safe"
        }
    };
}