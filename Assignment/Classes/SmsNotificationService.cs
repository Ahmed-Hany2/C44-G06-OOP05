using Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Classes
{
    public class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine("Sending SMS to: " + recipient);
            Console.WriteLine("Message: " + message);
            Console.WriteLine();
        }
    }
}
