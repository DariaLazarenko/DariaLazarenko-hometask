using System;

namespace DariaLazarenko_hometask
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //SlotMachine();
                //HomeTaskLesson1();

                //Test72();
                //Test73(); - возведение в степень и "склеивание" нескольких чисел в одно
                // int number = int.Parse(first.ToString() + second.ToString() + third.ToString());
                //Test56();
            }

            static void HomeTaskLesson1()
            {
                Console.WriteLine("Enter personal information");

                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                name = name.Trim();
                name = name.ToUpper();

                Console.WriteLine("Surname:");
                string surname = Console.ReadLine();
                surname = surname.Trim();
                surname = surname.ToUpper();

                Console.WriteLine("Age:");
                string age = Console.ReadLine();
                age = age.Trim();
                int agenum = int.Parse(age);

                Console.WriteLine("Height:");
                string height = Console.ReadLine();
                height = height.Trim();
                decimal heightnum = decimal.Parse(height.Replace(".", ","));

                Console.WriteLine("Your adress");

                Console.WriteLine("Street:");
                string street = Console.ReadLine();
                street = street.Trim();

                Console.WriteLine("House:");
                string house = Console.ReadLine();
                house = house.Trim();
                decimal housenum = decimal.Parse(house);

                Console.WriteLine("Housing:");
                string housing = Console.ReadLine();
                housing = housing.Trim();
                decimal housingnum = decimal.Parse(housing);

                Console.WriteLine("Flat:");
                string flat = Console.ReadLine();
                flat = flat.Trim();
                decimal flatnum = decimal.Parse(flat);

                Console.WriteLine("Phone number:");
                string phone = Console.ReadLine();
                phone = phone.Trim();

                if (agenum <= 0 || heightnum <= 0 || housenum <= 0 || housingnum <= 0 || flatnum <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid data entry\nTry again");
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("Personal information:");
                    Console.WriteLine($"Name: {name} {surname}");
                    Console.WriteLine($"Age: {agenum}\nHeight: {heightnum}");
                    Console.WriteLine($"Adress: {street} {housenum}/{housingnum}, flat {flatnum}");
                    Console.WriteLine($"Phone: {phone}");
                }
            }

            static void SlotMachine()
            {
                Console.WriteLine("Welcome!\nEnter your name:");
                string name = Console.ReadLine();
                Console.WriteLine("Now enter your age:");
                string age = Console.ReadLine();
                int agenum = int.Parse(age);

                if (agenum < 18)
                {
                    Console.WriteLine("Sorry, but you're too young to play this game :(");
                }

                else
                {
                    Console.WriteLine("Enter your bet ($):");
                    string bet = Console.ReadLine();
                    int betnum = int.Parse(bet);

                    if (betnum <= 0 || betnum < 5 || betnum > 101 || betnum % 5 != 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid data entry\nTry again");
                    }

                    else
                    {
                        Console.WriteLine("The moment of truth!");
                        Random random = new Random();
                        int first = random.Next(1, 10);
                        int second = random.Next(1, 10);
                        int third = random.Next(1, 10);
                        Console.WriteLine($" {first} {second} {third}");

                        if (first == 7 && first == second && second == third)
                        {
                            Console.WriteLine($"WOW {name} EPIC WIN {betnum * first * 150 * 1.5}$ !");
                        }

                        else if (first == second && second == third)
                        {
                            Console.WriteLine($"WOW {name} YOU WON {betnum * first * 10 * 1.5}$ !");
                        }

                        else if (first == 7 && first == second)
                        {
                            Console.WriteLine($"WOW  {name} YOU WON {betnum * 15 * 1.5}$ !");
                        }

                        else if (first == second)
                        {
                            Console.WriteLine($"WOW {name} YOU WON {betnum * first * 1.25}$ !");
                        }

                        else if (first == 7 || second == 7 || third == 7)
                        {
                            Console.WriteLine($"WOW {name} YOU WON {betnum * 1.6}$ !");
                        }

                        else if (first == 9 || second == 9 || third == 9)
                        {
                            Console.WriteLine($"WOW {name} YOU WON {betnum * 1.35}$ !");
                        }

                        else
                        {
                            Console.WriteLine($"{name} you lost :(");
                        }

                    }
                }
            }

            static void Test72()
            {
                /*
                 * 72. Дано трехзначное число. Определить, какая из его цифр больше:
                 * а) первая или последняя;
                 * б) первая или вторая;
                 * в) вторая или последняя.
                 * 
                 * я решила разобрать условие как 3 отдельных случая. 
                 * можно запихнуть и в один, но тогда нужно проверять кучу условий.
                 */

                Random random = new Random();
                int first = random.Next(1, 10);
                int second = random.Next(1, 10);
                int third = random.Next(1, 10);
                Console.WriteLine($"{first}{second}{third}");
                Console.WriteLine("Какая из цифр больше: первая или последняя?");

                if (first > third)
                {
                    Console.WriteLine("первая цифра больше последней\n");
                }
                else if (third > first)
                {
                    Console.WriteLine("последняя цифра больше первой\n");
                }
                else
                {
                    Console.WriteLine("они равны\n");
                }

                int first1 = random.Next(1, 10);
                int second1 = random.Next(1, 10);
                int third1 = random.Next(1, 10);
                Console.WriteLine($"{first1}{second1}{third1}");
                Console.WriteLine("Какая из цифр больше: первая или вторая?");

                if (first1 > second1)
                {
                    Console.WriteLine("первая цифра больше второй\n");
                }
                else if (second1 > first1)
                {
                    Console.WriteLine("вторая цифра больше первой\n");
                }
                else
                {
                    Console.WriteLine("они равны\n");
                }

                int first2 = random.Next(1, 10);
                int second2 = random.Next(1, 10);
                int third2 = random.Next(1, 10);
                Console.WriteLine($"{first2}{second2}{third2}");
                Console.WriteLine("Какая из цифр больше: вторая или последняя?");

                if (third2 > second2)
                {
                    Console.WriteLine("последняя цифра больше второй\n");
                }
                else if (second2 > third2)
                {
                    Console.WriteLine("вторая цифра больше последней\n");
                }
                else
                {
                    Console.WriteLine("они равны\n");
                }
            }

            static void Test73()
            {
                /*73.Дано трехзначное число. 
                 * Определить, равен ли квадрат этого числа сумме кубов его цифр.
                 * Вот вы приколист, а я ведь сразу и не поняла, что таких чисел просто нет
                 */

                Random ran = new Random();
                int first = ran.Next(1, 10);
                int second = ran.Next(1, 10);
                int third = ran.Next(1, 10);
                int number = int.Parse(first.ToString() + second.ToString() + third.ToString());

                //double firstNum = Convert.ToDouble(first);
                //double secondNum = Convert.ToDouble(second);
                //double thirdNum = Convert.ToDouble(third);
                //double newNumber = Convert.ToDouble(number);

                Console.WriteLine($"{number}\nОпределить, равен ли квадрат этого числа сумме кубов его цифр.");

                int x = 2;
                int y = 3;

                if (Math.Pow(number, x) == (Math.Pow(first, y) + Math.Pow(second, y) + Math.Pow(third, y)))
                {
                    Console.WriteLine($"{number}^2=({first}^3+{second}^3+{third}^3\nДа, квадрат этого числа равен сумме кубов его цифр");
                }
                else
                {
                    Console.WriteLine("Нет, квадрат этого числа не равен сумме кубов его цифр\nТаких в принципе не существует, как показал гугл,\nзато я выучила метод возведения в степень\n");
                }

                Console.WriteLine($"{number}\nОпределить, равено ли данное число сумме кубов его цифр.\nт.е. является ли оно числом Армстронга");

                if (number == (Math.Pow(first, y) + Math.Pow(second, y) + Math.Pow(third, y)))
                {
                    Console.WriteLine($"{number}=({first}^3+{second}^3+{third}^3\nДа, это число Армстронга");
                }
                else
                {
                    Console.WriteLine("Нет, это не число Армстронга");
                }
            }

            static void Test56()
            {
                //56.Если целое число m делится нацело на целое число n, 
                //то вывести на экран частное от деления,
                //в противном случае вывести сообщение «m на n нацело не делится».

                Random random = new Random();
                int m = random.Next(1001);
                int n = random.Next(1001);
                double newM = Convert.ToDouble(m);
                Console.WriteLine($"{newM}/{n}={newM/n}");

                if (newM > n && (newM % n) == 0)
                {
                    Console.WriteLine($"{newM % n}");
                }
                else
                {
                    Console.WriteLine("m на n нацело не делится");
                }
            }
        }
    }
}
    

