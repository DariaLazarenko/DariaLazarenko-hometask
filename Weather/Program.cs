using System;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дом. задание 1: погода
            Weather thisWeek = new Weather();

            Day d23_08_21 = new Day(new DateTime(2021, 8, 23), 17, 28, Cloudiness.Ясно, null, 30, 3, WindDirection.Север);

            thisWeek.AddDay(d23_08_21);

            Console.WriteLine(d23_08_21.Info());
        }
    }
}
