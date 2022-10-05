using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        /// <summary>
        /// Выводит символы столько раз, сколько задаст пользователь.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="symbolsCount"></param>
        static void PrintString(string symbol, uint symbolsCount)
        {

            for (int i = 0; i < symbolsCount; i++)
            {
                Console.Write(symbol);
            } 
        }

        static int getIndex(int[] array, int item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item)
                    return i;
            }
            return -1;
        }

        static int[] GetRandomArray(uint length, int minValue, int maxValue)
        {
            Random rnd = new Random();
            int[] myArray = new int[length];

            foreach (var item in myArray)
            {
                myArray[item] = rnd.Next(minValue, maxValue);
            }
            return myArray;
        }
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                //Console.WriteLine("Введите символ строки: ");
                //string c = Console.ReadLine();
                //Console.WriteLine("Введите количество символов: ");
                //PrintString(c, uint.Parse(Console.ReadLine()));

                int[] myArray = GetRandomArray(10,-10,10);
                Console.WriteLine("Введите элемент для поиска:");

                int element = int.Parse(Console.ReadLine());
                Console.WriteLine("Индекса элемента: " + getIndex(myArray, element));










                Console.WriteLine("\nКлавиша Esc для выхода. Любая другая клавиша запустит программу заново.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
