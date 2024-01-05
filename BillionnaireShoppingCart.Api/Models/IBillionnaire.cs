namespace BillionnaireShoppingCart.Api.Models;

public interface IBillionnaire
{
    public string Name { get; }
    public int NetWorth { get; }
    public string ImagePath { get; }
}