using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_1
{

    internal class Program
    {
        public static long[] Digitize(long n)
        {
            //int n = 123456789;
            //int digitCount = (int)Math.Log10(n) + 1;

            //int x;
            //do Console.Write("x = ");
            //while (!int.TryParse(Console.ReadLine(), out x));

            //long t = Math.Abs((long)x);
            //Console.WriteLine("Количество цифр: {0}", t == 0 ? 1 : (int)Math.Log10(t) + 1);

            int length = n.ToString().Length;
            long[] array = new long[length];
            long[] arr = { 0 };
            if (n == 0)
            {
                return arr;
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    array[i] = n % 10;
                    n /= 10;
                }
                return array;
            }
        }
        static void Main(string[] args)
        {
            long[] arr = new long[5];
            arr = Digitize(12345612341);

            Console.WriteLine(string.Join(",", arr));
        }
    }
}
