using Microsoft.ServiceBus.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace VisualPush.WebAPI.Controllers
{
    public class NotificationController : ApiController
    {
        public HttpResponseMessage Put(string connection, string path, string payload, DateTime datetime)
        {

            NotificationHubClient hub = NotificationHubClient.CreateClientFromConnectionString("", "tokiota");

            var toast = @"<toast><visual><binding template=""ToastText01""><text id=""1"">Sample toast notification!</text></binding></visual></toast>";

            var live = @"<tile><visual version=""2""><binding template=""TileWide310x150ImageAndText01"" fallback=""TileWideImageAndText01""><image id=""1"" src=""http://tokiota.com/images/tiles/widetile-tokiota-310-b.jpg"" alt=""alt text""/><text id=""1"">Tokiota Pawa!</text></binding></visual></tile>";

            // hub.SendWindowsNativeNotificationAsync(live, "Live_Tiles");

            //  hub.SendWindowsNativeNotificationAsync(live, "Live Tiles");
            Notification notification = new WindowsNotification(payload);
            notification.Headers.Add("X-WNS-Expires", datetime.ToString("R"));
            hub.SendNotificationAsync(notification, "Live_Tiles");

            return Request.CreateResponse(HttpStatusCode.OK, true);
        }
    }
}
