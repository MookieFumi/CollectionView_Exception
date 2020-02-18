using System.Collections.Generic;
using CollectionViewTest.Model;

namespace CollectionViewTest.Services
{
    public interface IOrdersService
    {
        IEnumerable<Order> GetOrders();
    }
}