using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatre
{
    public class Scheduler
    {
        public static List<Movie> AllMovies { get; set; }
        public static int WorkTime { get; set; }
        public int FreeTime { get; set; }
        public Schedule CurrentSchedule { get; set; }
        public Schedule BestSchedule { get; set; }

        public Scheduler()
        {
            CurrentSchedule = new Schedule(WorkTime);
            BestSchedule = new Schedule(WorkTime);
            FreeTime = WorkTime;
        }
        public void setFirstBestSchedule()
        {
            for (int i = 0; i < AllMovies.Count; ++i)
            {
                if (!BestSchedule.Movies.Contains(AllMovies[i]))
                {
                    ++BestSchedule.UniqMovies;
                }
                if (FreeTime >= AllMovies[i].Length)
                {
                    BestSchedule.Movies.Add(AllMovies[i]);
                    FreeTime -= AllMovies[i].Length;
                }
                else
                {
                    break;
                }
            }
            if (FreeTime >= AllMovies[0].Length)
            {
                setFirstBestSchedule();
            }
        }
        public void FindBestSchedule()
        {
            
        }

    }
    

   
}
