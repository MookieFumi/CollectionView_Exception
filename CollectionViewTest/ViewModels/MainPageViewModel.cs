using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using CollectionViewTest.Converters;
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

            LoadDataCommand = new DelegateCommandAsync(LoadData);
            Orders = new ObservableCollection<GroupedOrder>();
        }

        public ObservableCollection<GroupedOrder> Orders
        {
            get => _orders;
            set => SetProperty(ref _orders, value);
        }

        public override async Task OnNavigatedImpl(INavigationParameters parameters)
        {
            await LoadData();

            await base.OnNavigatedImpl(parameters);
        }

        public DelegateCommandAsync LoadDataCommand { get; private set; }

        private async Task LoadData()
        {
            await Task.Delay(99);

            Orders.Clear();

            try
            {

                var result = await _ordersService.GetOrders();

                var orders = BackendToModelMapper.GetOrders(result, "€");

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
        }
    }
}
