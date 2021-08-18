using System;

namespace Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Далее будут тесты по массивам
            //ОДНОМЕРНЫЕ:
            //Test2arr();
            //Test3arr();
            //Test11arr();
            // В 11 тесте на массивы есть метод поиска простых чисел isSimple
            //Test12arr();
            //Test13arr();
            //Test22arr();
            //Test30arr();
            //ДВУМЕРНЫЕ:

            //Позже разобрать сортировку методом фон Нейма

            //ExampleOfUsingArray();
            //int[] arr34 = { 3, 5, -3, 8, 0, 7, -4, 0 };
            //Test34arr(arr34);
            

            static void ExampleOfUsingArray()
            {
                //Также можно сделать через сортировку, и это будет правильно,
                //но лучше засунуть все в 1 цикл и все.

                Random r = new Random();

                int[] debit = new int[12];
                int[] credit = new int[12];
                int[] delta = new int[12];

                int sum = 0;

                int maxDelta = int.MinValue;

                int minDelta = int.MaxValue;

                int positiveDeltaCount = 0;

                for (int i = 0; i < debit.Length; i++)
                {
                    debit[i] = r.Next(10000);
                    credit[i] = r.Next(10000);

                    delta[i] = debit[i] - credit[i];

                    sum += delta[i];

                    if (delta[i] >= maxDelta)
                    {
                        maxDelta = delta[i];
                    }
                    if (delta[i] <= minDelta && delta[i] >= 0)
                    {
                        minDelta = delta[i];
                    }
                    if (delta[i] >= 0)
                    {
                        positiveDeltaCount++;
                    }
                }
                Console.WriteLine("Прибыль");
                foreach (int item1 in debit)
                {
                    Console.WriteLine(item1);
                }
                Console.WriteLine("Затраты");
                foreach (int item2 in credit)
                {
                    Console.WriteLine(item2);
                }
                Console.WriteLine("Доход по месяцам");
                foreach (int item3 in delta)
                {
                    Console.WriteLine(item3);
                }
                Console.WriteLine($"Сумма дохода: {sum}");
                Console.WriteLine($"Максимальный доход за месяц: {maxDelta}");
                Console.WriteLine($"Минимальный доход за месяц: {minDelta}");
                Console.WriteLine($"Месяцы с положительным заработком: {positiveDeltaCount}");
            }

            static void Test2arr()
            {
                //Заполнить массив из десяти
                //элементов значениями, вводимыми
                //с клавиатуры в ходе выполнения программы.

                int[] array = new int[10];
                Console.WriteLine("Заполните массив из 10 элементов числами:");

                for (int i = 0; i < array.Length; i++)
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    array[i] = num;
                }
                Console.Clear();
                Array.Sort(array);
                Console.WriteLine("Отсортированный массив:");
                foreach (int item in array)
                {
                    Console.WriteLine(item);
                }
            }

            static void Test3arr()
            {
                /*
                 * Заполнить массив из пятнадцати элементов случайным образом:
                 * а) вещественными значениями, лежащими в диапазоне от 0 до 1;
                 * б) вещественными значениями х (22 ≤ х < 23);
                 * в) вещественными значениями х (0 ≤ х < 10);
                 * г) вещественными значениями х (–50 ≤ х < 50);
                 * д) целыми значениями, лежащими в диапазоне от 0 до 10 включительно.
                 */

                double[] arr1 = new double[15];
                double[] arr2 = new double[15];
                double[] arr3 = new double[15];
                double[] arr4 = new double[15];
                int[] arr5 = new int[15];

                Random r = new Random();

                //a) вещественными значениями, лежащими в диапазоне от 0 до 1;
                for (int i = 0; i < arr1.Length; i++)
                {
                    arr1[i] = r.NextDouble();
                }
                Console.WriteLine("1 массив:");
                foreach (double item in arr1)
                {
                    Console.WriteLine(item);
                }

                //б) вещественными значениями х (22 ≤ х < 23);
                for (int i = 0; i < arr2.Length; i++)
                {
                    arr2[i] = r.NextDouble() + 22;
                }
                Console.WriteLine("2 массив:");
                foreach (double item in arr2)
                {
                    Console.WriteLine(item);
                }

                //в) вещественными значениями х (0 ≤ х < 10);
                for (int i = 0; i < arr3.Length; i++)
                {
                    arr3[i] = r.NextDouble() * 10;
                }
                Console.WriteLine("3 массив:");
                foreach (double item in arr3)
                {
                    Console.WriteLine(item);
                }

                //г) вещественными значениями х (–50 ≤ х < 50);
                for (int i = 0; i < arr4.Length; i++)
                {
                    arr4[i] = r.NextDouble() * -100 + 50;
                }
                Console.WriteLine("4 массив:");
                foreach (double item in arr4)
                {
                    Console.WriteLine(item);
                }

                //д) целыми значениями, лежащими в диапазоне от 0 до 10 включительно.
                for (int i = 0; i < arr5.Length; i++)
                {
                    arr5[i] = r.Next(11);
                }
                Console.WriteLine("5 массив:");
                foreach (int item in arr5)
                {
                    Console.WriteLine(item);
                }
            }

            static void Test11arr()
            {
                /*
                 * Заполнить массив:
                 * а) двадцатью первыми натуральными числами, делящимися нацело 
                 * на 13 или на 17 и большими 300;
                 */


                int[] arr1 = new int[20];
                int x = 300;

                for (int i = 0; i < arr1.Length; i++)
                {
                    x++;
                    for (; ; )
                    {
                        if (x % 13 == 0 || x % 17 == 0)
                        {
                            arr1[i] = x;
                            Console.WriteLine(arr1[i]);
                            break;
                        }
                        else
                        {
                            x++;
                        }
                    }

                }

                // б) тридцатью первыми простыми числами.

                int[] arr2 = new int[30];
                int y = 1;

                for (int i = 0; i < arr2.Length; i++)
                {
                    y++;
                    for (; ; )
                    {
                        if (isSimple(y))
                        {
                            arr2[i] = y;
                            Console.WriteLine(arr2[i]);
                            break;
                        }
                        else
                        {
                            y++;
                        }
                    }
                }
                //метод который определяет простое число или нет
                static bool isSimple(int N)
                {
                    //чтоб убедится простое число или нет достаточно проверить не делитсья ли 
                    //число на числа до его половины
                    for (int i = 2; i <= (N / 2); i++)
                    {
                        if (N % i == 0)
                            return false;
                    }
                    return true;
                }
            }

            static void Test12arr()
            {
                //12. Составить программу вывода на экран
                //любого элемента массива.
                //Номер элемента запрашивается у пользователя.

                int[] arr = { 3, 5, 78, 4, 55, 72, 34, 78, 88, 1 };
                //Random r = new Random();

                //for (int i = 0; i < arr.Length; i++)
                //{
                //    arr[i] = r.Next(100);
                //}

                Console.WriteLine("Введите индекс массива от 0 до 9 включительно:");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Значение {index} элемента:");
                Console.WriteLine(arr[index]);
            }

            static void Test13arr()
            {
                //13. Вывести элементы массива на экран в обратном порядке.
                // не будем использовать Reverse

                int[] arr = { 4, 5, 7, 8, 9, 3, 6 };
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(arr[i]);
                }
            }

            static void Test22arr()
            {
                //Дан массив целых чисел. Выяснить:
                //а) верно ли, что сумма элементов массива есть четное число;
                //б) верно ли, что сумма квадратов элементов массива есть пятизначное число;
                //в) верно ли, что сумма элементов массива неотрицательна.

                int[] arr = new int[10];
                Random r = new Random();
                int sum = 0;
                int sum2 = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = r.Next(-100, 101);
                    Console.WriteLine(arr[i]);

                    sum += arr[i];
                    Console.WriteLine(sum);
                    sum2 += arr[i] * arr[i];


                }

                if (sum % 2 == 0)
                {
                    Console.WriteLine("Сумма элементов четная");
                }
                else
                {
                    Console.WriteLine("Сумма элементов неченая");
                }

                if (sum2 > 9999 && sum2 < 100000)
                {
                    Console.WriteLine("Сумма квадратов элементов массива\nпятизначное число");
                }
                else
                {
                    Console.WriteLine("Сумма квадратов элементов массива\nНЕ пятизначное число");
                }

                if (sum >= 0)
                {
                    Console.WriteLine("Сумма значений элементов неотрицательная");
                }
                else
                {
                    Console.WriteLine("Сумма значений элементов отрицательная");
                }

            }

            static void Test30arr()
            {
                //Дана последовательность натуральных чисел а1, а2, ..., an.
                //Создать массив из четных чисел этой последовательности.
                //Если таких чисел нет, то вывести сообщение об этом факте.

                Random r = new Random();
                int[] arr = new int[10];

                for (int j = 0; j < arr.Length;)
                {
                    int i = r.Next(1, 31);
                    if (i % 2 == 0)
                    {
                        for (; ; )
                        {
                            arr[j] = i;
                            Console.WriteLine(arr[j]);
                            j++;
                            i = r.Next(1, 31);
                            break;
                        }
                    }
                    else
                    {
                        i = r.Next(1, 31);
                    }
                }
            }

            static Tuple<int, int, int> Test34arr(int[] array)
            {
                //Дан массив вещественных чисел, размер которого N.
                //Подсчитать, сколько в нем отрицательных, положительных и нулевых элементов.


                int sumZ = 0;
                int sumPos = 0;
                int sumNeg = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0)
                    {
                        sumZ++;
                    }
                    else if (array[i] < 0)
                    {
                        sumNeg++;
                    }
                    else
                    {
                        sumPos++;
                    }
                }
                return Tuple.Create(sumPos, sumNeg, sumZ);
            }
        }
     
    }
}
