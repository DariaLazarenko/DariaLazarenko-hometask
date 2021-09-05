using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public abstract class Crew : Airline
    {
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected int Age { get; set; }
        public Post CrewPost { get; set; }

        protected Crew(string name, string surname)
        {
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname))
            {
                throw new Exception("Name or Surname field cannot be empty");

                //Проверку на возраст не делаю, так как поставила рандомайзер.
            }
            else
            {
                Name = name;
                Surname = surname;
            }

        }

        public override string ToString()
        {
            string info =
                "Crewmate info: " +
                $"Post: {CrewPost}\n" +
                $"Name: {Name};\n" +
                $"Surname: {Surname};\n" +
                $"Age: {Age}.\n";
            return info;

        }

        public enum Post
        {
            Commander = 1,
            Second_pilot,
            Navigator,
            Mechanic,
            Stewardess
        }
    }
}
