using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    class Navigator : Crew
    {
        public Navigator(string name, string surname) : base(name, surname)
        {
            var r = new Random();
            Age = r.Next(25, 66);
            CrewPost = Post.Navigator;
        }
    }
}
