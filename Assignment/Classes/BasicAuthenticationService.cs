using Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Classes
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private string[] usernames = { "admin1", "user1" };
        private string[] passwords = { "admin123", "123456" };
        private string[] roles = { "Admin", "User" };

        public bool AuthenticateUser(string username, string password)
        {
            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == username && passwords[i] == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == username && roles[i] == role)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
