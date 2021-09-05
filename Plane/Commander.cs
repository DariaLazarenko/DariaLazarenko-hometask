using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    class Commander : Crew
    {
        public Commander(string name, string surname) : base(name, surname)
        {
            var r = new Random();
            Age = r.Next(30, 61);
            CrewPost = Post.Commander;
        }
    }
}
