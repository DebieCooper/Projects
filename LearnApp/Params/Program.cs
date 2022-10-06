using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Params
{
    internal class Program
    {
        static int Sum(string msg, params int[] parameters)
        {
            int result = 0;

            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }

            return result;
        }

        static void Foo(params object[] parameters)
        {
            string message = "Тип данных {0}, значение {1}";
            foreach (var item in parameters)
            {
                Console.WriteLine(message, item.GetType(), item);
            }
        }
        static void Main(string[] args)
        {
            int result = Sum("message", 5, 6, 3, 15);

            Console.WriteLine(result);
        }
    }
}
