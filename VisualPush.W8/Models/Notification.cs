using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPush.W8.Models
{
    public class NotificationSetup
    {
        public string Payload { get; set; }
        public string StringConnection { get; set; }
        public string Path { get; set; }
        public string Tags { get; set; }
        public DateTime Expiry { get; set; }
    }
}
