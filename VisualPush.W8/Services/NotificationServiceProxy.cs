namespace VisualPush.W8.Services
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using VisualPush.W8.Models;
    using Windows.Web.Http;

    public class NotificationServiceProxy : INotificationService
    {
        private string clientBaseUrl = string.Format(CultureInfo.InvariantCulture, "{0}/api/Notification", Constants.ServerAddress);
        
        public async Task SendNotificationAsync(NotificationSetup notificationSetup)
        {
            using (var client = new HttpClient())
            {
                var serializedNotificationSetup = JsonConvert.SerializeObject(notificationSetup);

                var response = await client.PutAsync(new Uri(clientBaseUrl), new HttpStringContent(serializedNotificationSetup, Windows.Storage.Streams.UnicodeEncoding.Utf8, "application/json"));
                response.EnsureSuccessStatusCode();
            }
        }
    }
}
