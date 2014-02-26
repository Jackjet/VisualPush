using Microsoft.Practices.Prism.StoreApps;
using Microsoft.Practices.Prism.StoreApps.Interfaces;

namespace VisualPush.W8.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        private INavigationService _navigationService;

        public string Payload { get; set; }

        public string StringConnection { get; set; }
        public string Path { get; set; }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Payload = @"<tile><visual version=""2""><binding template=""TileWide310x150ImageAndText01"" fallback=""TileWideImageAndText01""><image id=""1"" src=""http://tokiota.com/images/tiles/widetile-tokiota-310-b.jpg"" alt=""alt text""/><text id=""1"">Tokiota Pawa!</text></binding></visual></tile>";
            StringConnection = "";
            Path = "tokiota";
        }

        private void Send()
        {
           
        }
    }
}
