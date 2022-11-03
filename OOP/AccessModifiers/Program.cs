using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    //Модификаторы private и public
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(5,7);
            point.PrintY();
            point.PrintPoint();

            var typeInfo = typeof(Point).
                GetFields(BindingFlags.Instance |
                BindingFlags.NonPublic |
                BindingFlags.Public);

            foreach (var item in typeInfo)
            {
                Console.WriteLine($"{item.Name} \t IsPrivate: {item.IsPrivate} \t IsPublic: {item.IsPublic}");
            }
        }
    }
}
