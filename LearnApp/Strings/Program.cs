using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество букв в слове: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите строку: ");
            string text = Console.ReadLine();
            string text2 = "";
            Console.WriteLine($"Строка, которая не содержит слова больше чем {n}");

text = Regex.Replace(text, @"\b[а-яА-Я]{1,4}\b", "");
            Console.WriteLine(text);

            Console.ReadLine();
        }
    }
}
