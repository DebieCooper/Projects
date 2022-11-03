using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static Student GetStudent()
        {
            var student = new Student();

            student.firstName = "Мартин";
            student.middleName = "Игоревич";
            student.lastName = "Дугин";
            student.age = 19;
            student.id = Guid.NewGuid();
            student.group = "йцукен_1\n";

            return student;
        }

        static void Main(string[] args)
        {
            Student firstStudent = new Student();
            firstStudent = GetStudent();
            firstStudent.Print();

            Student secondStudent = new Student();
            secondStudent.Print();

            string fullName = firstStudent.GetFullName();
            Console.WriteLine($"\n{fullName}\n");

            Console.WriteLine("\t== Car 1 ==");
            var car = new Car();
            car.PrintSpeed();
            car.DriveForward();
            car.PrintSpeed();
            car.Stop();
            car.PrintSpeed();


            Console.WriteLine("\t== Car 2 ==");
            var car2 = new Car();
            car2.PrintSpeed();
            car2.DriveBackward();
            car2.PrintSpeed();
            car2.Stop();
            car2.PrintSpeed();

        }
    }
}
