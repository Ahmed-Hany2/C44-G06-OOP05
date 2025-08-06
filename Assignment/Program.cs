using Assignment.Classes;
using Assignment.Interfaces;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question (1)
            ICircle Circle1 = new Circle(5.5);
            IRectangle Rectangle1 = new Rectangle(4.5, 7);

            Circle1.DisplayShapeInfo();
            Rectangle1.DisplayShapeInfo();

            // Question (2)
            IAuthenticationService authService = new BasicAuthenticationService();

            string username = "user1";
            string password = "123456";
            string role = "Admin";

            bool isAuthenticated = authService.AuthenticateUser(username, password);
            Console.WriteLine($"Authentication result: {isAuthenticated}");

            bool isAuthorized = authService.AuthorizeUser(username, role);
            Console.WriteLine($"Authorization result: {isAuthorized}");

            //Question (3)
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();


            emailService.SendNotification("Ahmed@yahoo.com", "Welcome to the app!");
            smsService.SendNotification("0123456789", "code is 1234.");
            pushService.SendNotification("user_01", "You have a new message");
        }
    }
}
