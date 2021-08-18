using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class PublishingHouse
    {
       //Большая морока включать в конструкторы для книг, пусть будет доп. опцией
        
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public PublishingHouse(string name, string country, string city)
        {
            Name = name;
            Country = country;
            City = city;
        }


    }
}
