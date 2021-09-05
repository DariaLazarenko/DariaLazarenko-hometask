using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class CargoPlane : Plane
    {
        public int LiftingCapacity { get;}

        public CargoPlane()
        {
            var r = new Random();
            Model = "Boeing-B";
            Number = r.Next(100, 301);
            PlaneType = PlaneType.Cargo;
            crew = new List<Crew>();
            int liftingCap = r.Next(50, 121);
            LiftingCapacity = liftingCap;
        }

        public override void AddCrew()
        {
            var commander = new Commander("Peter", "Lazor");
            crew.Add(commander);
            var secondPilot = new SecondPilot("Bob", "Marley");
            crew.Add(secondPilot);
            var navigator = new Navigator("Michale", "Jacson");
            crew.Add(navigator);

            if (LiftingCapacity <= 90)
            {
                for (int i = 1; i <= 3; i++)
                {
                    var mechanic = new Mechanic("Elly", "Cooper");
                    crew.Add(mechanic);
                }
            }
            else if (LiftingCapacity <= 120)
            {
                for (int i = 1; i <= 5; i++)
                {
                    var mechanic = new Mechanic("Elly", "Cooper");
                    crew.Add(mechanic);
                }
            }
        }

        public override string ToString()
        {
            string info =
               "Type: Cargo plane\n" +
               $"Title: {Name}\n" +
               $"Lifting Capasity: {LiftingCapacity} tonnes;\n" +
               "Crew info:\n";
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
