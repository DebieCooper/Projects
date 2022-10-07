using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Methods_Arrays
{
    internal class Program
    {
        static void FillArray(int[] array, int start, int end)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(start,end);
        }
        static void ReversePrint(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
                Console.WriteLine($"[{i}] = {array[i]}");
        }
        static int FindMin(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }
        static int SumEvenNumbers(int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Введите размер массива: ");

            bool isValidLength = uint.TryParse(Console.ReadLine(), out uint n);
            int[] myArray = new int[n];
                
            if (isValidLength)
            {
                Console.Clear();
                Console.WriteLine("Введите диапазон значений: ");
                bool isValidStart = int.TryParse(Console.ReadLine(), out int start);
                bool isValidEnd = int.TryParse(Console.ReadLine(), out int end);

                if (isValidStart && isValidEnd)
                {
                    FillArray(myArray, start, end);

                    Console.WriteLine("Идет заполнение массива! ");
                    Thread.Sleep(2000);

                    Console.WriteLine("\nВывод массива в обратном порядке: ");
                    ReversePrint(myArray);

                    Console.WriteLine("Минимальный элемент массива: " + FindMin(myArray));
                    Console.WriteLine("Сумма четных элементов массива " + SumEvenNumbers(myArray));
                }
                else
                    Console.Write("Неверный ввод!");
            }
            else
                Console.Write("Неверный ввод!");

            Console.ReadKey();
        }
    }
}
