using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics.CodeAnalysis;

namespace LearnApp
{
    internal class Program
    {
        //Подсчет суммы цифр числа: 8 => 8+7..+1 = 36
        //https://letstalkscience.ca/educational-resources/backgrounders/gauss-summation
        //https://en.wikipedia.org/wiki/Triangular_number
        //public static int summation(int num)
        //{
        //    int sum = 0;
        //    while (num > 0)
        //    {
        //        sum += num--;
        //    }
        //    return sum;
        //    //return num*(num+1)/2;
        //}

        static void PrintArray(int[] arr, int i)
        {
            if (i < arr.Length)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
                PrintArray(arr, i+1);
            }
        }
        static int Sum(int[] arr, int i = 0)
        {
            if (i >= arr.Length)
                return 0;

            int result = Sum(arr, i+1);
            return arr[i] + result;
        }
        static void Main(string[] args)
        {
            #region start
            //Console.WriteLine("Вводим строку: ");
            //string str = Console.ReadLine();

            //Console.WriteLine("Выводим строку: ");
            //Console.WriteLine(str);


            //=================================================

            //string str = "5.9";

            //NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            //{
            //    NumberDecimalSeparator = ".",
            //};

            //double a = double.Parse(str, numberFormatInfo);
            //Console.WriteLine(a);

            //=================================================

            //string str = "5";

            //try
            //{
            //    double a = double.Parse(str);
            //    Console.WriteLine("Успешная конвертация");
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Ошибка при конвертации");
            //}

            //=================================================

            //string str = "4";

            //int b;

            //bool result = int.TryParse(str, out b);
            #endregion

            int[] myArray = { 1, 2, 3, 4, 5};

            PrintArray(myArray, 0);
            Console.WriteLine(Sum(myArray));


            Console.ReadLine();
        }
    }
}
