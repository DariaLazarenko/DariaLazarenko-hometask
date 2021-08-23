using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    class Day
    {
        public DateTime Date { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public Cloudiness? Cloudiness { get; set; }
        public Precipitation? Precipitation { get; set; }
        public int Humidity { get; set; }
        public int WindStrength { get; set; }
        public WindDirection? WindDirection { get; set; }

        public Day(DateTime date, int minTemp, int maxTemp, Cloudiness? cloudiness, Precipitation? precipitation, int humidity, int windStrength, WindDirection? windDirection)
        {
            Date = date;

            if (MinTemp <= MaxTemp)
            {
                MinTemp = minTemp;
                MaxTemp = maxTemp;
            }
            else
            {
                MinTemp.ToString("Некорректное значение ");
                MaxTemp.ToString("Некорректное значение ");
            }

            Cloudiness = cloudiness;
            Precipitation = precipitation;

            if (Humidity >= 0)
            {
                Humidity = humidity;
            }
            else
            {
                Humidity.ToString("Некорректное значение ");
            }

            if (WindStrength >= 0)
            {
                WindStrength = windStrength;
            }
            else
            {
                WindStrength.ToString("Некорректное значение ");
            }

            WindDirection = windDirection;
        }

        public string Info()
        {
            string info =
                $"Дата: {Date.ToString()};\n" +
                $"Минимальная температура: {MinTemp}°C;\n" +
                $"Максимальная температура: {MaxTemp}°C;\n";

            if (Cloudiness is null)
            {
                info += "Облачность: Не определено;\n";
            }
            else
            {
                info += $"Облачность: {Cloudiness.ToString().Replace("_", " ")};\n";
            }

            if (Precipitation is null)
            {
                info += "Осадки: Не определено;\n";
            }
            else
            {
                info += $"Осадки: {Precipitation.ToString().Replace("_", " ")};\n";
            }
            
            info += 
                $"Влажность: {Humidity}%;\n" +
                $"Сила ветра: {WindStrength} м/с;\n";

            if (WindDirection is null)
            {
                info += "Направление ветра: Не определено;\n";
            }
            else
            {
                info += $"Направление ветра: {WindDirection.ToString().Replace("_", "-")};\n";
            }

            info += "Это был весь прогноз погоды на сегодня.";
            return info;
        }
    }
    public enum Cloudiness
    {
        Ясно,
        Малооблачно,
        Облачно,
        Грозовые_тучи
    }
    public enum Precipitation
    {
        Дождь,
        Снег,
        Дождь_со_снегом,
        Град,
        Снежная_крупа,
        Роса,
        Иней,
        Изморозь,
        Гололед,
        Ледяные_иглы
    }
    public enum WindDirection
    {
        Север,
        Северо_восток,
        Восток,
        Юго_восток,
        Юг,
        Юго_запад,
        Запад,
        Северо_запад
    }
}
