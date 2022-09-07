using System;
namespace Dz2
{
    public class Cotegory
    {
        public string Namecot;
        public Tovar[] Tovars;
        public Cotegory(string namecot, Tovar[] tovars)
        {
            Namecot = namecot;
            Tovars = tovars;
        }
    }
}

