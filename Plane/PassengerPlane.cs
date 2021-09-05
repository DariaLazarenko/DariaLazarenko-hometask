using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class PassengerPlane : Plane
    {
        public int PassNum { get;}

        public PassengerPlane()
        {
            var r = new Random();
            Model = "Airbus-A";
            Number = r.Next(100, 301);
            PlaneType = PlaneType.Passenger;
            crew = new List<Crew>();
            int passNum = r.Next(80, 151);
            PassNum = passNum;
        }

        public override void AddCrew()
        {
            var commander = new Commander("Alex", "Walker");
            crew.Add(commander);
            var secondPilot = new SecondPilot("Tom", "Brown");
            crew.Add(secondPilot);
            var navigator = new Navigator("John", "Green");
            crew.Add(navigator);

            if (PassNum <= 100)
            {
                for (int i = 1; i <= 3; i++)
                {
                    var stewardess = new Stewardess("Sam", "Parker");
                    crew.Add(stewardess);
                }
            }
            else if (PassNum <= 150)
            {
                for (int i = 1; i <= 5; i++)
                {
                    var stewardess = new Stewardess("Sam", "Parker");
                    crew.Add(stewardess);
                }
            }
        }

        public override string ToString()
        {
            string info =
               "Type: Passanger plane\n" +
               $"Title: {Name}\n" +
               $"Passengers amount: {PassNum} people;\n";
               
            if (crew is not null)
            {
                info += "Crew info:\n";
                foreach (var person in crew)
                {
                    info += person.ToString();
                }
                return info;
            }
            else
            {
                return info;
            }
        }

        //public override void CheckCrew()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
