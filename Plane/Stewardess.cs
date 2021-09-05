using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    class Stewardess : Crew
    {
        public Stewardess(string name, string surname) : base(name, surname)
        {
            var r = new Random();
            Age = r.Next(21, 46);
            CrewPost = Post.Stewardess;
        }
    }
}
