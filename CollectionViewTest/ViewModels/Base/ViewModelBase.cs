using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Navigation;

namespace CollectionViewTest.ViewModels.Base
{
    public class ViewModelBase : BindableBase, IInitializeAsync, INavigatedAware
    {
        public ViewModelBase()
        {
        }

        public virtual async Task InitializeAsync(INavigationParameters parameters)
        {
            await Task.Delay(0);
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            OnNavigatedImpl(parameters);
        }

        public virtual Task OnNavigatedImpl(INavigationParameters parameters)
        {
            return Task.CompletedTask;
        }
    }
}
