using System;
using System.Collections.Generic;
using System.Text;

namespace MstdnAPI
{
    public class Notification
    {
        public string Id { get; set; }
        public NotificationType Type { get; set; }
        public DateTime CreatedAt { get; set; }
        public Account Account { get; set; }
        public Status Status { get; set; }
    }
}
