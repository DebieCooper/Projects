using System.Text;

namespace AlfredProject
{
    internal class Program
    {
        //static int[] GetArray()
        //{
        //    int[] myArray = null;
        //    return myArray;
        //} 
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
                Console.WriteLine(string.Join(",", myArray)); //Хитровыебанный вывод
                */
                #endregion

                #region Задачи с одномерным массивом
                /*
                Console.WriteLine("Введите размер массива: ");
                bool isValidArray = true;
                bool isValidLength = UInt32.TryParse(Console.ReadLine(), out uint n);
                int[] myArray = new int[n];
                
                int sum = 0;
                int minItem = 0;

                if (isValidLength)
                {
                    Console.Clear();
                    Console.WriteLine("Введите элементы массива: ");
                    for (int i = 0; i < myArray.Length; i++)
                    {
                        Console.Write($"[{i}] = ");
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
                            isValidArray = false;
                            break;
                        }                       
                    }

                    if (isValidArray)
                    {
                        Console.WriteLine("\nВывод массива в обратном порядке: ");
                        minItem = myArray[0];
                        for (int i = myArray.Length - 1; i >= 0; i--)
                        {   
                            if (myArray[i] < minItem)
                            {
                                minItem = myArray[i];
                            }
                            Console.WriteLine($"[{i}] = {myArray[i]}" );
                        }
                        Console.WriteLine($"\n\nСумма четных чисел массива: {sum}");
                        Console.WriteLine($"\nМинимальный элемент массива: {minItem}");
                    }
                }
                else
                    Console.Write("Неверный ввод!");
                */
                #endregion

                #region Двумерные массивы, начало.
                /*
                int[,] myArray = new int[,]
                {
                    {2, 45, 12, 51, 51},
                    {6, 7, 8, 3, 1 },
                    {6, 12, 45, 12, 43 },
                    {6, 3, 151, 5, 65 }
                };

                //foreach (var item in myArray)
                //{
                //    Console.Write(item + " ");
                //}
                int height = myArray.GetLength(0); //Строки. Высота матрицы
                int width = myArray.GetLength(1); //Столбцы. Ширина матрицы

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Console.Write(myArray[y,x] + "\t");
                    }
                    Console.WriteLine();
                }
                */
                #endregion

                #region Двумерные массивы. Заполнение случайными числами
                /*
                Console.WriteLine("Введите размер матрицы n x m: ");
                bool isValidItems;
                bool isValidDimensionN = uint.TryParse(Console.ReadLine(), out uint n);
                bool isValidDimensionM = uint.TryParse(Console.ReadLine(), out uint m);

                int[,] myArray = new int[n, m];
                Random rnd = new Random(); 


                if (isValidDimensionN && isValidDimensionM == true)
                {
                    //Заполнение массива случайными числами
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.Write($"[{i},{j}]= ");
                            isValidItems = int.TryParse(Console.ReadLine(), out myArray[i,j]);

                            if (isValidItems == false)
                            {
                                Console.WriteLine("Неверный ввод!");
                                break;
                            }
                                //myArray[i, j] = rnd.Next(100);
                        }
                    }
                    //Вывод массива
                    for (int y = 0; y < n; y++)
                    {
                        for (int x = 0; x < m; x++)
                        {
                            Console.Write(myArray[y,x] + "\t");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод размеров матрицы!");
                }*/
                #endregion

                #region Cтупенчатые массивы
                /*
                int[][] myArray = new int[3][];
                int[,] myArray2 = new int[3, 5];

                myArray[0] = new int[5];
                myArray[1] = new int[2];
                myArray[2] = new int[10];

                Random rnd = new Random();

                for (int i = 0; i < myArray.Length; i++)
                {
                    for (int j = 0; j < myArray[i].Length; j++)
                    {
                        myArray[i][j] = rnd.Next(100);
                    }
                }

                for (int i = 0; i < myArray.Length; i++)
                {
                    for (int j = 0; j < myArray[i].Length; j++)
                    {
                        Console.Write(myArray[i][j] + "\t");
                    }
                    Console.WriteLine();
                }
                */
                #endregion

                #region Оператор null-обьединения - ??
                /*
                string str = null;

                //string result = str ?? "нет данных";
                string result = str ?? string.Empty;

                Console.WriteLine("Количество символов в строке " + result.Length);
                */
                #endregion

                #region Оператор присваивания обьединения со значением NULL - ??=
                /*
                string str = null;

                //string result = str ?? "нет данных";
                str ??= string.Empty;

                Console.WriteLine("Количество символов в строке: " + str.Length);

                int[] myArray = null;

                //myArray = myArray ?? "default"
                myArray ??= new int[10];
                Console.WriteLine("Количество элементов в массиве: " + myArray.Length);
                */
                #endregion

                #region Оператор условного null - ?.
                /*
                int[] myArray = GetArray();

                Console.WriteLine("Сумма элементов массива: " + (myArray?.Sum() ?? 0));
                */
                #endregion




























                Console.WriteLine("\nКлавиша Esc для выхода. Любая другая клавиша запустит программу заново.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}