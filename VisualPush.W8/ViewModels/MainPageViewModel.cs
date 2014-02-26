using Microsoft.Practices.Prism.StoreApps;
using Microsoft.Practices.Prism.StoreApps.Interfaces;
using System;
using System.Windows.Input;
using VisualPush.W8.Services;

namespace VisualPush.W8.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        private INavigationService navigationService;
        private INotificationService notificationService;
        public string Payload { get; set; }
        public string StringConnection { get; set; }
        public string Path { get; set; }
        public string Tags { get; set; }
        public ICommand SendNotificationCommand { get; private set; }

        public MainPageViewModel(INavigationService navigationService, INotificationService notificationService)
        {
            this.navigationService = navigationService;
            this.notificationService = notificationService;

            Payload = @"<toast><visual><binding template=""ToastText01""><text id=""1"">Sample toast notification!</text></binding></visual></toast>";
            StringConnection = "";
            Path = "tokiota";
            Tags = "Live_Tiles";

            SendNotificationCommand = new DelegateCommand(SendNotification);
        }

        private void SendNotification()
        {
            notificationService.SendNotificationAsync(StringConnection, Path, Payload, DateTime.Now.ToUniversalTime().AddMinutes(10), Tags);
        }
    }
}
