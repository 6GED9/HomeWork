using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cotegory[] cotegories = new[] { new Cotegory("Фрукты", new Tovar[] { new Tovar("Апельсин", 10, 5),
                                                                              new Tovar("Банан", 5, 3)}) };

            Cotegory[] cotegories1 = new[] { new Cotegory("Ягоды", new Tovar[] { new Tovar("Малина", 2, 4),
                                                                              new Tovar("Клубника", 3, 5)}) };
            foreach (var cotegory in cotegories)
            {
                Console.WriteLine(cotegory.Namecot);
                foreach(var Tovar in cotegory.Tovars)
                {
                    Console.WriteLine(Tovar.Name + " " + Tovar.Coast + " " + Tovar.Rate);
                }
                Console.ReadLine();
            }
            foreach (var cotegory in cotegories1)
            {
                Console.WriteLine(cotegory.Namecot);
                foreach (var Tovar in cotegory.Tovars)
                {
                    Console.WriteLine(Tovar.Name + " " + Tovar.Coast + " " + Tovar.Rate);
                }
                Console.ReadLine();
            }
            User[] users = new[] {new User("login1", "password1", new Basket[] {new Basket(new Tovar[] {new Tovar("Апельсин", 10, 5),
                                                                                                        new Tovar("Малина", 2,4)})}),
                                  new User("login2", "password2", new Basket[] {new Basket(new Tovar[] {new Tovar("Клубника", 3, 5),
                                                                                                        new Tovar("Банан", 5,3)})})};
            foreach (var user in users)
            {
                Console.WriteLine(user.Login + " " + user.Password);
                foreach (var basket in user.Baskets)
                {
                    foreach(var Tovar in basket.Buytovar)
                    {
                        Console.WriteLine(Tovar.Name + " " + Tovar.Coast + " " + Tovar.Rate);
                    }
                }
                Console.ReadLine();
            }

        }
    }
}