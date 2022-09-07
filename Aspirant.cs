using System;
namespace Dz
{
    public class Aspirant:Student
    {
        public Aspirant(string firstname, string lastname, string group, double ocenka) : base(firstname, lastname, group, ocenka)
        {
            firstName = firstname;
            lastName = lastname;
            Group = group;
            averageMask = ocenka;
        }

        public override int getScholarship()
        {
            if (averageMask == 5)
                step = 20000;
            else
                step = 18000;
            return step;
        }
    }
}

