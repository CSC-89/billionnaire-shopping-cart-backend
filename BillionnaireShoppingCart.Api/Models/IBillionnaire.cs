namespace BillionnaireShoppingCart.Api.Models;

public interface IBillionnaire
{
    public string Name { get; }
    public long NetWorth { get; }
    public string ImagePath { get; }
}