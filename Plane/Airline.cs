using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Airline
    {
        private List<Plane> planes;

        public Airline()
        {
            planes = new List<Plane>();
        }

        private string PlaneInfo(Plane plane)
        {
            if (plane is not null)
            {
                string info = "Plane info:\n";

                if (plane.PlaneType == PlaneType.Cargo)
                {
                    plane = (CargoPlane)plane;
                    info += plane.ToString();
                    return info;
                }
                else
                {
                    plane = (PassengerPlane)plane;
                    info += plane.ToString();
                    return info;
                }
            }
            else
            {
                return "This plane doesn`t exist.";
            }
        }
    }
}
