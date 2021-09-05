using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    class SecondPilot : Crew
    {
        public SecondPilot(string name, string surname) : base(name, surname)
        {
            var r = new Random();
            Age = r.Next(25, 61);
            CrewPost = Post.Second_pilot;
        }
    }
}
