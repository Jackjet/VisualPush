using Microsoft.Practices.Prism.StoreApps;
using Microsoft.Practices.Prism.StoreApps.Interfaces;
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Serialization;
using VisualPush.W8.Models;
using VisualPush.W8.Services;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Provider;
using Windows.Storage.Streams;

namespace VisualPush.W8.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        private INavigationService navigationService;
        private INotificationService notificationService;
        public NotificationSetup CurrentNotification { get; set; }
        public ICommand SendNotificationCommand { get; private set; }
        public ICommand SaveCommand { get; private set; }

        public MainPageViewModel(INavigationService navigationService, INotificationService notificationService)
        {
            this.navigationService = navigationService;
            this.notificationService = notificationService;

            CurrentNotification = new NotificationSetup();
            
            SendNotificationCommand = new DelegateCommand(SendNotification);
            SaveCommand = DelegateCommand.FromAsyncHandler(Save);
        }

        private void SendNotification()
        {
            notificationService.SendNotificationAsync(CurrentNotification);
        }

        private async Task Save()
        {
            FileSavePicker savePicker = new FileSavePicker();
            savePicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            savePicker.FileTypeChoices.Add("XML file", new List<string>() { ".xml" });
            savePicker.SuggestedFileName = "New Document";
            StorageFile file = await savePicker.PickSaveFileAsync();

            if (file != null)
            {
                using (var stream = await file.OpenAsync(FileAccessMode.ReadWrite))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(NotificationSetup));
                    serializer.Serialize(stream.AsStreamForWrite(), CurrentNotification);
                    await stream.FlushAsync();
                    stream.Size = stream.Position;
                }
            }

            
        }

    }
}
