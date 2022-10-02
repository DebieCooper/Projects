using System.Text;
using System.Text.Unicode;

namespace AlfredProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Настройка консоли
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "🕓 Time application";
            Console.CursorVisible = true;
            #endregion
            //ConsoleKeyInfo input;
            do
            {
                Console.Clear();

                #region Инкремент, треугольник, математические операции.
                /*
                int a = 1;
                a = ++a * a;
                Console.WriteLine(a);


                Console.Write("Введите высоту треугольника: ");
                int height = int.Parse(Console.ReadLine());

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
                */
                #endregion

                #region Треугольники сложные
                /*Console.Write("Введите высоту треугольника: ");

                int height = int.Parse(Console.ReadLine());

                for (int i = 0; i < height; i++)
                {
                    for (int j = height; j > i; j--)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }

                Console.Write("Введите высоту треугольника: ");

                int height = int.Parse(Console.ReadLine());

                for (int i = 0; i < height; i++)
                {
                    for (int j = height; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
                */
                #endregion

                #region Тернарный оператор
                /*
                 Тернарный оператор
                    string storedPass = "qwer";
                string enteredPass = Console.ReadLine();
                bool accessAllowed;

                //accessAllowed = storedPass == enteredPass ? true : false;

                switch (enteredPass)
                {
                    case "qwer":
                        accessAllowed = true;
                        break;
                    default:
                        accessAllowed = false;
                        break;
                }

                //input = Console.ReadKey();
                Console.WriteLine(accessAllowed);
                while (input.Key != ConsoleKey.Escape);
                */
                #endregion

                #region Одномерные массивы
                /*
                int[] myArray0 = new int[5];
                int[] myArray1 = new int[] { 5, 6, 7, 8, 9 };
                int[] myArray2 = { 5, 6, 7, 8, 9 };

                Заполнение массива 5-ками на 1- эелментов
                int[] myArray = Enumerable.Repeat(5, 10).ToArray();

                Заполнение последовательно от начиная с 4 до 10 позиции
                int[] myArray = Enumerable.Range(4, 10).ToArray();
                Console.WriteLine(String.Join(",", myArray)); //Хитровыебанный вывод
                */
                #endregion
                #region Задачи с одномерным массивом

                Console.WriteLine("Введите размер массива: ");
                bool isValidLength = Int32.TryParse(Console.ReadLine(), out int n);
                int[] myArray = new int[n];
                bool flag = true;
                int sum = 0;
                int minItem = 0;

                if (isValidLength)
                {
                    Console.Clear();
                    Console.WriteLine("Введите элементы массива: ");
                    for (int i = 0; i < myArray.Length; i++)
                    {
                        bool isValidItems = Int32.TryParse(Console.ReadLine(), out int item);
                        if (isValidItems)
                        {
                            myArray[i] = item;
                            if (myArray[i] % 2 == 0)
                            {
                                sum += myArray[i];
                            }
                        }
                        else
                        {
                            Console.WriteLine("Неверный ввод элементов!");
                            flag = false;
                            break;
                        }                       
                    }

                    if (flag)
                    {
                        Console.WriteLine("\nВывод массива в обратном порядке: ");
                        minItem = myArray[0];
                        for (int i = myArray.Length - 1; i >= 0; i--)
                        {   
                            if (minItem > myArray[i])
                            {
                                minItem = myArray[i];
                            }
                            Console.Write(myArray[i] + " ");
                        }
                        Console.WriteLine($"\n\nСумма четных чисел массива: {sum}");
                        Console.WriteLine($"\nМинимальный элемент массива: {minItem}");
                    }
                }
                else
                    Console.Write("Неверный ввод!");
                #endregion

              Console.WriteLine("\nКлавиша Esc для выхода. Любая другая клавиша запустит программу заново.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}