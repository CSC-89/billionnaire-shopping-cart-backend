namespace BillionnaireShoppingCart.Api.Models;

public interface IProduct
{
    public string Name { get; set; }
    public int Price { get; set; }
    public string ImagePath { get; set; }
}