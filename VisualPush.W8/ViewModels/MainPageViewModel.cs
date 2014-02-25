using Microsoft.Practices.Prism.StoreApps;
using Microsoft.Practices.Prism.StoreApps.Interfaces;

namespace VisualPush.W8.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        private INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
