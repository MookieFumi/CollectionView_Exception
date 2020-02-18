using System.Collections.Generic;

namespace CollectionViewTest.Model
{
    public class GroupedOrder : List<Order>
    {
        public string Name { get; private set; }

        public GroupedOrder(string name, List<Order> orders) : base(orders)
        {
            Name = name;
        }
    }
}
