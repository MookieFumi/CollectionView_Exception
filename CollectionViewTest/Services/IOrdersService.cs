using System.Collections.Generic;
using System.Threading.Tasks;
using CollectionViewTest.Model;

namespace CollectionViewTest.Services
{
    public interface IOrdersService
    {
        Task<IEnumerable<OrderDTO>> GetOrders();
    }
}