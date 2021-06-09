using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTheatre
{
    public partial class ScheduleForm : Form
    {
        public int WorkTime { get; set; }
        private int StartTimeHours { get; set; }
        private int FinishTimeHours { get; set; }
        private int StartTimeMinutes { get; set; }
        private int FinishTimeMinutes { get; set; }
        private Movie CurrentMovie { get; set; }
        private List<Movie> AllMovies { get; set; }
        private Schedule _schedule { get; set; }
        public ScheduleForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartTimeHours = 10;
            StartTimeMinutes = 0;
            FinishTimeHours = 24;
            FinishTimeMinutes = 0;
            WorkTime = 14*60;
            textBoxTimeDisplay.Text = WorkTime.ToString();
            CurrentMovie = new Movie();
            AllMovies = new List<Movie>();
        }

        private void textBoxStartTime_TextChanged(object sender, EventArgs e)
        {
            if (textBoxStartTime.Text.Length > 0)
            {
                double StartTime = Convert.ToDouble(textBoxStartTime.Text);
                StartTimeHours = (int)(Math.Floor(StartTime));
                StartTimeMinutes = (int)(StartTime - StartTimeHours);
                WorkTime = (FinishTimeHours - StartTimeHours) * 60 + (FinishTimeMinutes - StartTimeMinutes);
                textBoxTimeDisplay.Text = WorkTime.ToString();
            }
        }

        private void textBoxFinishTime_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFinishTime.Text.Length > 0)
            {
                double FinishTime = Convert.ToDouble(textBoxFinishTime.Text);
                FinishTimeHours = (int)Math.Floor(FinishTime);
                FinishTimeMinutes = (int)(FinishTime - FinishTimeHours);
                WorkTime = (FinishTimeHours - StartTimeHours) * 60 + (FinishTimeMinutes - StartTimeMinutes);
                textBoxTimeDisplay.Text = WorkTime.ToString();
            }
        }

        private void textBoxMovieName_TextChanged(object sender, EventArgs e)
        {
            CurrentMovie.Name = textBoxMovieName.Text.Trim();
        }

        private void textBoxMovieLength_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMovieLength.Text.Length>0)
            {
                CurrentMovie.Length = Convert.ToInt32(textBoxMovieLength.Text);
            }
        }

        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            Movie newMovie = new Movie(CurrentMovie.Name, CurrentMovie.Length);
            AllMovies.Add(newMovie);
            textBoxAllMovies.Text += CurrentMovie.Name + ",   " + CurrentMovie.Length + " min." + Environment.NewLine;
        }

        private void buttonGenerateSchedule_Click(object sender, EventArgs e)
        {
            Scheduler.AllMovies = AllMovies;
            Scheduler.WorkTime = WorkTime;

            textBoxSchedule.Text += "Schedule for today:" + Environment.NewLine;
            int movieStartTimeHours = StartTimeHours;
            int movieStartTimeMinutes = StartTimeMinutes;

            foreach (Movie m in _schedule.Movies)
            {
                int movieMinutes = m.Length;
                int movieHours = 0;
                while (movieMinutes >= 60)
                {
                    movieMinutes -= 60;
                    ++movieHours;
                }
                int movieEndHours = movieStartTimeHours + movieHours;
                int movieEndMinutes = movieStartTimeMinutes + movieMinutes;
                while (movieEndMinutes >= 60)
                {
                    movieEndMinutes -= 60;
                    movieEndHours++;
                }
                textBoxSchedule.Text += movieStartTimeHours + ":" + movieStartTimeMinutes + " - " + movieEndHours + ":" + movieEndMinutes + " - " + m.Name + Environment.NewLine;
                movieStartTimeHours = movieEndHours;
                movieStartTimeMinutes = movieEndMinutes;
            }
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            textBoxAllMovies.Clear();
            Movie Movie1 = new Movie("Lion King", 90);
            Movie Movie2 = new Movie("Wizard of OZ", 80);
            Movie Movie3 = new Movie("Mickey Mouse", 70);
            AllMovies.Add(Movie1);
            AllMovies.Add(Movie2);
            AllMovies.Add(Movie3);
            for (int i = 0; i < AllMovies.Count; ++i)
            {
                textBoxAllMovies.Text += AllMovies[i].Name + ", " + AllMovies[i].Length + " min." + Environment.NewLine;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            AllMovies.RemoveAt(AllMovies.Count-1);
            textBoxAllMovies.Clear();
            for (int i = 0; i < AllMovies.Count; ++i)
            {
                textBoxAllMovies.Text += AllMovies[i].Name + ", " + AllMovies[i].Length + " min." + Environment.NewLine;
            }
        }
    }
}
