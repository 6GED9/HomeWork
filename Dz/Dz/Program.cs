using System;

namespace Dz
{
    class Shop
    {
        static void Main(string[] args)
        {
            Student student1 = new Aspirant("fas","fasf","fsaf",3);
            Student[] students = new[] {new Student("ФИО 1", "Фамилия1", "Группа 1", 5),
                                        new Aspirant("ФИО 2", "Фамилия2", "Группа 2", 3)};
            foreach(var student in students)
            {
                Console.WriteLine(student.firstName + " " + student.lastName + " " + student.Group + " " + student.averageMask + " " + student.getScholarship());
                Console.ReadLine();
            }
        }
    }
}

