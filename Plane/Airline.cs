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

        private int OverallLifting { get; set; }
        private int OverallPassengers { get; set; }

        public Airline()
        {
            planes = new List<Plane>();
        }

        public void AddPlane(Plane plane)
        {
            if (plane is not null)
            {
                planes.Add(plane);
            }
        }

        public void Creation()
        {
            for (int i = 0; i < 60; i++)
            {
                if (i % 2 == 0)
                {
                    var plane = new CargoPlane();
                    plane.AddCrew();
                    AddPlane(plane);
                }
                else
                {
                    var plane = new PassengerPlane();
                    plane.AddCrew();
                    AddPlane(plane);
                }
            }
        }
        public string Statistics()
        {
            if (planes is not null)
            {
                string info =
                    $"Planes quantity: {planes.Count};\n";
                int cargoNum = 0;
                int passNum = 0;

                for (int i = 0; i < planes.Count; i++)
                {
                    if (planes[i].GetType() == typeof(CargoPlane))
                    {
                        cargoNum++;
                        var cargo = new CargoPlane();
                        cargo = (CargoPlane)planes[i];
                        OverallLifting += cargo.LiftingCapacity;
                    }
                    else 
                    {
                        passNum++;
                        var pass = new PassengerPlane();
                        pass = (PassengerPlane)planes[i];
                        OverallPassengers += pass.PassNum;
                    }
                }

                info +=
                    $"Overrall:\n" +
                    $"Cargo planes quantity: {cargoNum};\n" +
                    $"Lifting capacity: {OverallLifting} tonnes;\n" +
                    $"Passanger planes quantity: {passNum};\n" +
                    $"Passangers amount: {OverallPassengers} people;\n";
                return info;
            }
            else
            {
                return "No planes found";
            }
        }

        public string PlaneInfo(Plane plane)
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
