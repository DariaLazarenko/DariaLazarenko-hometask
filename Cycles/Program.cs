using System;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //Test5();
            //Test4();
            //Test7();
            //Test2();
            //Test3();
            //Test1();

            //ExampleOfUsingCyclesAndMethods();
        }

        static void ExampleOfUsingCyclesAndMethods()
        {
            //Примеры использования методов и циклов с 3 занятия 

            //Test 6 lab4
            for (int i = 0; i < 101; i++)
            {
                double f = ((double)9 / 5) * i + 32;

                Console.WriteLine($"{i}°C  -  {Math.Round(f)}°F");
            }


            for (bool z = true; z == true;)
            {
                Console.WriteLine("\nEnter int number:");
                string str = Console.ReadLine();
                z = int.TryParse(str, out int x);
                if (z == false)
                {
                    Console.WriteLine("Wrong format");
                    z = true;
                }
                else if (z == true)
                {
                    z = false;
                }
            }
            Console.WriteLine("Well done");


            //Console.WriteLine("Enter int number");
            //string str1 = Console.ReadLine();
            //if (!int.TryParse(str1, out int p))
            //{
            //    Console.WriteLine("Wrong format");
            //}
            //else
            //{
            //    Console.WriteLine("Well done");
            //}
        }

        static void Test1()
        {
            //В заданном натуральном числе поменять порядок
            //цифр на обратный и сравнить полученное число с исходным.

            int a = 12345;
            string str = a.ToString();
            char[] ar = str.ToCharArray();
            Array.Reverse(ar);
            str = new string(ar);
            a = Convert.ToInt32(str);
            Console.WriteLine(a);

            //Второй способ, не понятно, нашла в интернете

            Console.WriteLine("Enter number");
            int x = int.Parse(Console.ReadLine());
            int new_x = x % 10;
            x /= 10;
            while (x >= 1)
            {
                new_x *= 10;
                new_x += x % 10;
                x /= 10;
            }
            Console.WriteLine(new_x);
        }

        static void Test2()
        {
            //Для заданного числа найти все его делители.

            Random r = new Random();
            int a = r.Next(1, 101);
            Console.WriteLine($"Для числа {a} делителями будут:"); ;

            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Test3()
        {
            //Натуральное число называют совершенным,
            //если оно равно сумме всех своих делителей, включая 1.
            //Например, 6 = 1 + 2 + 3.
            //Найти совершенные числа, меньшие заданного числа N.

            Random random = new Random();
            int n = random.Next(1, 50001);
            Console.WriteLine(n);

            for (int num = n; num > 1; num--)
            {
                int sum = 0;

                for (int divider = 1; divider < num; divider++)
                {
                    if (num % divider == 0)
                    {
                        sum += divider;
                    }
                }

                if (num == sum)
                {
                    Console.WriteLine(num);
                }
            }
        }

        static void Test4()
        {
            // Проверить, существуют ли натуральные числа а < 100,
            // которые обладают следующими свойствами:
            // а) a % 3 = 1;
            // б) a % 4 = 2;
            // в) a % 5 = 3;
            // г) a % 6 = 4.
            //Сколько таких чисел ?

            int sum = 0;
            for (int a = 1; a < 100; a++)
            {
                int a3 = a % 3;
                if (a3 == 1)
                {
                    sum++;
                }

                int a4 = a % 4;
                if (a4 == 2)
                {
                    sum++;
                }

                int a5 = a % 5;
                if (a5 == 3)
                {
                    sum++;
                }

                int a6 = a % 6;
                if (a6 == 4)
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }

        static void Test5()
        {
            //Написать программу, которая выводит на экран 
            //таблицу квадратов и кубов целых чисел а от 1 до 10.
            //Столбцы таблицы должны иметь обозначения, 
            //например, а, а^2, а^3.

            Console.WriteLine($"a   -   a^2   -   a^3");
            for (int a = 1; a < 11; a++)
            {
                int a2 = a * a;
                int a3 = a * a * a;
                Console.WriteLine($"{a}       {a2}          {a3}");
            }
            Console.WriteLine("End");
        }

        static void Test7()
        {
            //Напишите программу, 
            //которая выводит в столбец произведения 
            //чисел а = 143, b = 777 и чисел 1, 2, 3, ... 9.

            decimal a = 143;
            decimal b = 777;
            for (int i = 1; i < 10; i++)
            {
                decimal x = a * i;
                decimal y = b * i;
                Console.WriteLine($"{x}  -  {y}");
            }

        }
    }
}
