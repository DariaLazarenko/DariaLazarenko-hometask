using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public abstract class Plane
    {
        protected string Model { get; set; }
        protected int Number { get; set; }
        protected string Name { get => $"{Model}{Number}"; }
        public PlaneType PlaneType { get; set; }

        protected List<Crew> crew;

        public abstract void AddCrew();
        //public abstract void CheckCrew();
    }

    public enum PlaneType
    {
        Cargo,
        Passenger
    }
}
