namespace BillionnaireShoppingCart.Api.Models;

public class Billionnaire : IBillionnaire
{
    public string Name { get; set; }
    public long NetWorth { get; set; }
    public string ImagePath { get; set; }
}