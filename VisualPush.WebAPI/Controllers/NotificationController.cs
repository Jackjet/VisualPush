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

    public class NotificationController : ApiController
    {
        public async Task<HttpResponseMessage> Put(string connection, string path, string payload, DateTime datetime, string tags)
        {
            NotificationHubClient hub = NotificationHubClient.CreateClientFromConnectionString(connection, path);

            Notification notification = new WindowsNotification(payload);
            notification.Headers.Add("X-WNS-Expires", datetime.ToString("R"));
            await hub.SendNotificationAsync(notification, tags);

            return Request.CreateResponse(HttpStatusCode.OK, true);
        }
    }
}
