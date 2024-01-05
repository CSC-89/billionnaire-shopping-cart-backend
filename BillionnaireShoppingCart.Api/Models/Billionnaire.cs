namespace BillionnaireShoppingCart.Api.Models;

public class Billionnaire : IBillionnaire
{
    public string Name { get; set; }
    public int NetWorth { get; set; }
    public string ImagePath { get; set; }
}