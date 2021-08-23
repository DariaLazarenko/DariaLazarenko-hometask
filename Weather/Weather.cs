using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    class Weather
    {
        private Day[] weather;

        public Weather()
        {
            weather = new Day[0];
        }

        public void AddDay(Day day)
        {
            if (day is not null)
            {
                Array.Resize(ref weather, weather.Length + 1);
                weather[weather.Length - 1] = day;
            }
            else
            {
                Console.WriteLine("Была попытка добавить пустой день");
            }
        }
    }
}
