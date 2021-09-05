using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    class Mechanic : Crew
    {
        public Mechanic(string name, string surname) : base(name, surname)
        {
            var r = new Random();
            Age = r.Next(25, 66);
            CrewPost = Post.Mechanic;
        }
    }
}
