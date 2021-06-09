using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatre
{
    public class Movie
    {
        public string Name { get; set; }
        public int Length { get; set; }

        public Movie()
        {

        }
        public Movie(string name, int length)
        {
            Name = name;
            Length = length;
        }
    }
}
