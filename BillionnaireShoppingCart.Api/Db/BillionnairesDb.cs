using System.Collections.Generic;
namespace BillionnaireShoppingCart.Api.Db;

public class BillionnairesDb
{
    public BillionnairesDb(string type)
    {
        
        Data = new List<>
    }
    public List<T> Data { get; }
}