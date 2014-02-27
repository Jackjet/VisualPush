using System;
namespace VisualPush.W8.Services
{
    using System.Threading.Tasks;
    using VisualPush.W8.Models;

    public interface INotificationService
    {
       Task SendNotificationAsync(NotificationSetup notification);
    }
}
