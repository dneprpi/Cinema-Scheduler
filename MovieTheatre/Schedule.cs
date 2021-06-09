using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatre
{
    public class Schedule
    {
        public int FreeTime { get; set; }
        public int TotalLength { get; set; }
        public List<Movie> Movies { get; set; }
        public int UniqMovies { get; set; }
        public Schedule(int freeTime)
        {
            FreeTime = freeTime;
            Movies = new List<Movie>();
            UniqMovies = 0;
            TotalLength = 0;
        }
    }
}
