using System;
namespace Dz2
{
    public class User
    {
        public string Login;
        public string Password;
        public Basket[] Baskets; 
        public User(string login, string password, Basket[] baskets)
        {
            Login = login;
            Password = password;
            Baskets = baskets;
        }
    }
}

