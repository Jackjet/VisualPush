namespace VisualPush.W8.Services
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Windows.Web.Http;

    public class NotificationServiceProxy : INotificationService
    {
        private string clientBaseUrl = string.Format(CultureInfo.InvariantCulture, "{0}/api/Notification", Constants.ServerAddress);
        
        public async Task SendNotificationAsync(string connection, string path, string payload, DateTime datetime, string tags)
        {
            using (var client = new HttpClient())
            {
                var response = await client.PutAsync(new Uri(clientBaseUrl + "/?connection=" + Uri.EscapeDataString(connection) + "&path=" + path + "&payload=" + payload + "&datetime=" + datetime + "&tags=" + tags), null);
                response.EnsureSuccessStatusCode();
            }
        }
    }
}
