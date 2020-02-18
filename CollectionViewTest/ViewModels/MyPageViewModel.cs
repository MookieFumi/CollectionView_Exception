using System.Collections.ObjectModel;
using CollectionViewTest.ViewModels.Base;

namespace CollectionViewTest.ViewModels
{
    public class MyPageViewModel : ViewModelBase
    {
        private ObservableCollection<MenuItem> _menuItems;

        public MyPageViewModel()
        {
            MenuItems = new ObservableCollection<MenuItem>
            {
                new MenuItem { Title = "One" },
                new MenuItem { Title = "Two" },
                new MenuItem { Title = "Three" },
                new MenuItem { Title = "Four" },
                new MenuItem { Title = "Five" },
                new MenuItem { Title = "Six" },
            };
        }

        public ObservableCollection<MenuItem> MenuItems
        {
            get => _menuItems;
            set => SetProperty(ref _menuItems, value);
        }
    }

    public class MenuItem
    {
        public string Title { get; set; }
    }
}
