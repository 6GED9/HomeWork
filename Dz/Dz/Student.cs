using System;
namespace Dz
{
    public class Student
    {
        public string firstName;
        public string lastName;
        public string Group;
        public double averageMask;
        public int step = 0;
        
        public virtual int getScholarship()
        {
            if (averageMask == 5)
                step = 10000;
            else
                step = 8000;
            return step;
        }
        public Student(string firstname, string lastname, string group, double ocenka)
        {
            firstName = firstname;
            lastName = lastname;
            Group = group;
            averageMask = ocenka;
        }
    }
}

