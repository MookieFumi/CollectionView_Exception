using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using CollectionViewTest.Model;
using CollectionViewTest.Services;
using CollectionViewTest.ViewModels.Base;
using Prism.Navigation;

namespace CollectionViewTest.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IOrdersService _ordersService;
        private ObservableCollection<GroupedOrder> _orders;

        public MainPageViewModel(IOrdersService ordersService)
        {
            _ordersService = ordersService;

            Orders = new ObservableCollection<GroupedOrder>();
        }

        public ObservableCollection<GroupedOrder> Orders
        {
            get => _orders;
            set => SetProperty(ref _orders, value);
        }

        public override async Task OnNavigatedImpl(INavigationParameters parameters)
        {
            Orders.Clear();

            try
            {
                var orders = _ordersService.GetOrders();

                var todayOrders = new GroupedOrder("Today", orders
                    .Where(s => s.DisplayedInitialTime.Date.Equals(DateTime.Now.Date))
                    .OrderByDescending(o => o.DisplayedInitialTime).ToList());
                if (todayOrders.Any())
                {
                    Orders.Add(todayOrders);
                }

                var nextOrders = new GroupedOrder("Next", orders
                    .Where(s => s.DisplayedInitialTime.Date > DateTime.Now.Date)
                    .OrderByDescending(o => o.DisplayedInitialTime)
                    .ToList());
                if (nextOrders.Any())
                {
                    Orders.Add(nextOrders);
                }

                var previousOrders = new GroupedOrder("Previous", orders
                    .Where(s => s.DisplayedInitialTime.Date < DateTime.Now.Date)
                    .OrderByDescending(o => o.DisplayedInitialTime)
                    .ToList());
                if (previousOrders.Any())
                {
                    Orders.Add(previousOrders);
                }
            }
            catch (Exception exception)
            {

            }

            await base.OnNavigatedImpl(parameters);
        }
    }
}
