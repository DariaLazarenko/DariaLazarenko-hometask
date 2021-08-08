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
                

            }

            private static void HomeTaskLesson1()
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
                long phonenum = long.Parse(phone);

                if (agenum <= 0 || heightnum <= 0 || housenum <= 0 || housingnum <= 0 || flatnum <= 0 || phonenum <= 0)
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
                    Console.WriteLine($"Phone: {phonenum}");
                }
            }

            private static void SlotMachine()
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

        }
    }
}
    

