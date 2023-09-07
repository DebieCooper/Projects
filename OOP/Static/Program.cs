using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass();

            Console.WriteLine(myClass1.ObjectsCount);

            MyClass myClass2 = new MyClass();

            Console.WriteLine(myClass1.GetObjectsCount());


            MyClass myClass3 = new MyClass();
            Console.WriteLine(MyClass.Counter);
            Console.WriteLine(MyClass.GetCounter());

        }
    }
}
