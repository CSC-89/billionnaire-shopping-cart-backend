using System.Collections.Generic;
using System.Collections;

namespace BillionnaireShoppingCart.Api.Db;

public interface IDatabase<T>
{
    public List<T> Data { get; set; }
}