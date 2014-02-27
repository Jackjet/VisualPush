namespace VisualPush.WebAPI.Controllers
{
    using Microsoft.ServiceBus.Notifications;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Web.Http;
    using VisualPush.WebAPI.Models;

    public class NotificationController : ApiController
    {
        public async Task<HttpResponseMessage> Put(NotificationSetup notificationSetup)
        {
            NotificationHubClient hub = NotificationHubClient.CreateClientFromConnectionString(notificationSetup.StringConnection, notificationSetup.Path);

            Notification notification = new WindowsNotification(notificationSetup.Payload);
            notification.Headers.Add("X-WNS-Expires", notificationSetup.Expiry.ToString("R"));
            await hub.SendNotificationAsync(notification, notificationSetup.Tags);

            return Request.CreateResponse(HttpStatusCode.OK, true);
        }
    }
}
