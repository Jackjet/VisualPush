using System;
namespace VisualPush.W8.Services
{
    using System.Threading.Tasks;

    public interface INotificationService
    {
       Task SendNotificationAsync(string connection, string path, string payload, DateTime datetime, string tags);
    }
}
