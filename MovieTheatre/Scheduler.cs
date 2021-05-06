using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatre
{
    public class Scheduler
    {
        public static List<Movie> Movies { get; set; }
        public int FreeTime { get; set; }
        public List<Movie> CurrentMovies { get; set; }
        public List<Scheduler> NextMovie { get; set; }
        public int UniqMovies { get; set; }

        public Scheduler(int freeTime, List<Movie> currentMovies = null)
        {
            FreeTime = freeTime;
            NextMovie = new List<Scheduler>();
            if (currentMovies is null)
            {
                CurrentMovies = new List<Movie>();
            }
            else
            {
                CurrentMovies = currentMovies;
            }
        }

        public void CreateGraph()
        {
            foreach(Movie m in Movies)
            {
                if (FreeTime >= m.Length)
                {
                    List<Movie> tmp = new List<Movie>(CurrentMovies);
                    tmp.Add(m);
                    Scheduler scheduler = new Scheduler(FreeTime - m.Length, tmp);
                    NextMovie.Add(scheduler);
                    ++scheduler.UniqMovies;
                    scheduler.CreateGraph();
                }
            }
        }
        public string WriteAllLeaves()
        {
            StringBuilder sb = new StringBuilder();
            if (NextMovie.Count == 0)
            {
                foreach(Movie m in CurrentMovies)
                {
                   sb.Append(m.Name + " ");
                }
                sb.Append(Environment.NewLine);
            }
            else
            {
                foreach(Scheduler s in NextMovie)
                {
                    s.WriteAllLeaves();
                }
            }
            return sb.ToString();
        }

        public Schedule CreateSchedule()
        {
            if (NextMovie.Count == 0)
            {
                return new Schedule(FreeTime, CurrentMovies, UniqMovies);
            }
            else
            {
                List<Schedule> returnSchedules = new List<Schedule>();
                foreach(Scheduler s in NextMovie)
                {
                    returnSchedules.Add(s.CreateSchedule());
                }
                Schedule best = returnSchedules[0];
                
                foreach (Schedule b in returnSchedules)
                {
                    if (b.FreeTime <= best.FreeTime && b.UniqMovies > best.UniqMovies)
                    {
                        best = b;
                    }
                    else if ((b.FreeTime == best.FreeTime) && (best.UniqMovies < b.UniqMovies)
                        || (b.FreeTime == best.FreeTime) && (best.CurrentMovies.Count < b.CurrentMovies.Count))
                    {
                        best = b;
                    }
                }
                return best;
            }
        }
    }
    public class Movie
    {
        public string Name { get; set; }
        public int Length { get; set; }

        public Movie()
        {

        }
        public Movie (string name, int length)
        {
            Name = name;
            Length = length;
        }
    }

    public class Schedule
    {
        public int FreeTime { get; set; }
        public List<Movie> CurrentMovies { get; set; }
        public int UniqMovies { get; set; }
        public Schedule(int freeTime, List <Movie> currentMovies, int uniq)
        {
            FreeTime = freeTime;
            CurrentMovies = new List<Movie>(currentMovies);
            UniqMovies = uniq;
        }
    }
}
