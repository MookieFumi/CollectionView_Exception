using System.Collections.Generic;
using System.Linq;
using CollectionViewTest.Model;

namespace CollectionViewTest.Converters
{
    public static class BackendToModelMapper
    {
        public static IEnumerable<Order> GetOrders(IEnumerable<OrderDTO> orders, string currencySymbol)
        {
            if (orders is null || !orders.Any())
            {
                return Enumerable.Empty<Order>();
            }

            var converter = new OrderConverter(currencySymbol);

            return orders.Select(converter.Convert).ToList();
        }
    }
}
