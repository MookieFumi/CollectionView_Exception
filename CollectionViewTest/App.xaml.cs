using CollectionViewTest.Services;
using CollectionViewTest.ViewModels;
using CollectionViewTest.Views;
using Prism.Ioc;
using Prism.Unity;

namespace CollectionViewTest
{
    public partial class App : PrismApplication
    {
        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync($"{nameof(MyPage)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IOrdersService, OrdersService>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<MyPage, MyPageViewModel>();
        }
    }
}
