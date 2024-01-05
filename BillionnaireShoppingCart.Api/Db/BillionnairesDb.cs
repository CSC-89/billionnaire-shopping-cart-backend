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
        },
        new () {
            Name = "Jeff Bezos",
            NetWorth = 161000000000,
            ImagePath = "https://imageio.forbes.com/specials-images/imageserve/5bb22ae84bbe6f67d2e82e05/0x0.jpg?format=jpg&crop=1012,1013,x627,y129,safe"
        },
        new () {
            Name = "Larry Ellison",
            NetWorth = 158000000000,
            ImagePath = "https://specials-images.forbesimg.com/imageserve/5e8b62cfc095010007bffea0/416x416.jpg?background=000000&cropX1=0&cropX2=4529&cropY1=652&cropY2=5184"
        }
        
    };
}