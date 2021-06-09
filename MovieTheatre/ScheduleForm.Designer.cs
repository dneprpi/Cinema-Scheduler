
namespace MovieTheatre
{
    partial class ScheduleForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxStartTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFinishTime = new System.Windows.Forms.TextBox();
            this.textBoxTimeDisplay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAllMovies = new System.Windows.Forms.TextBox();
            this.textBoxMovieName = new System.Windows.Forms.TextBox();
            this.textBoxMovieLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSchedule = new System.Windows.Forms.TextBox();
            this.buttonGenerateSchedule = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxStartTime
            // 
            this.textBoxStartTime.Location = new System.Drawing.Point(118, 22);
            this.textBoxStartTime.Name = "textBoxStartTime";
            this.textBoxStartTime.PlaceholderText = "10.00";
            this.textBoxStartTime.Size = new System.Drawing.Size(58, 23);
            this.textBoxStartTime.TabIndex = 0;
            this.textBoxStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxStartTime.TextChanged += new System.EventHandler(this.textBoxStartTime_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start work at:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Finish work at:";
            // 
            // textBoxFinishTime
            // 
            this.textBoxFinishTime.Location = new System.Drawing.Point(118, 60);
            this.textBoxFinishTime.Name = "textBoxFinishTime";
            this.textBoxFinishTime.PlaceholderText = "24.00";
            this.textBoxFinishTime.Size = new System.Drawing.Size(58, 23);
            this.textBoxFinishTime.TabIndex = 2;
            this.textBoxFinishTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxFinishTime.TextChanged += new System.EventHandler(this.textBoxFinishTime_TextChanged);
            // 
            // textBoxTimeDisplay
            // 
            this.textBoxTimeDisplay.Enabled = false;
            this.textBoxTimeDisplay.Location = new System.Drawing.Point(118, 99);
            this.textBoxTimeDisplay.Name = "textBoxTimeDisplay";
            this.textBoxTimeDisplay.Size = new System.Drawing.Size(58, 23);
            this.textBoxTimeDisplay.TabIndex = 4;
            this.textBoxTimeDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Working time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "minutes";
            // 
            // textBoxAllMovies
            // 
            this.textBoxAllMovies.Location = new System.Drawing.Point(27, 259);
            this.textBoxAllMovies.Multiline = true;
            this.textBoxAllMovies.Name = "textBoxAllMovies";
            this.textBoxAllMovies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAllMovies.Size = new System.Drawing.Size(214, 233);
            this.textBoxAllMovies.TabIndex = 7;
            this.textBoxAllMovies.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxMovieName
            // 
            this.textBoxMovieName.Location = new System.Drawing.Point(109, 143);
            this.textBoxMovieName.Name = "textBoxMovieName";
            this.textBoxMovieName.Size = new System.Drawing.Size(132, 23);
            this.textBoxMovieName.TabIndex = 8;
            this.textBoxMovieName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMovieName.TextChanged += new System.EventHandler(this.textBoxMovieName_TextChanged);
            // 
            // textBoxMovieLength
            // 
            this.textBoxMovieLength.Location = new System.Drawing.Point(118, 181);
            this.textBoxMovieLength.Name = "textBoxMovieLength";
            this.textBoxMovieLength.PlaceholderText = "in minutes";
            this.textBoxMovieLength.Size = new System.Drawing.Size(123, 23);
            this.textBoxMovieLength.TabIndex = 9;
            this.textBoxMovieLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMovieLength.TextChanged += new System.EventHandler(this.textBoxMovieLength_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Movie Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Movie Length:";
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.Location = new System.Drawing.Point(27, 215);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(214, 23);
            this.buttonAddMovie.TabIndex = 12;
            this.buttonAddMovie.Text = "Add Movie";
            this.buttonAddMovie.UseVisualStyleBackColor = true;
            this.buttonAddMovie.Click += new System.EventHandler(this.buttonAddMovie_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "All Movies:";
            // 
            // textBoxSchedule
            // 
            this.textBoxSchedule.Location = new System.Drawing.Point(265, 87);
            this.textBoxSchedule.Multiline = true;
            this.textBoxSchedule.Name = "textBoxSchedule";
            this.textBoxSchedule.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSchedule.Size = new System.Drawing.Size(514, 434);
            this.textBoxSchedule.TabIndex = 14;
            this.textBoxSchedule.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonGenerateSchedule
            // 
            this.buttonGenerateSchedule.Location = new System.Drawing.Point(565, 55);
            this.buttonGenerateSchedule.Name = "buttonGenerateSchedule";
            this.buttonGenerateSchedule.Size = new System.Drawing.Size(214, 23);
            this.buttonGenerateSchedule.TabIndex = 15;
            this.buttonGenerateSchedule.Text = "Generate Schedule";
            this.buttonGenerateSchedule.UseVisualStyleBackColor = true;
            this.buttonGenerateSchedule.Click += new System.EventHandler(this.buttonGenerateSchedule_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(27, 498);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(75, 23);
            this.buttonRandom.TabIndex = 16;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(166, 498);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.buttonGenerateSchedule);
            this.Controls.Add(this.textBoxSchedule);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonAddMovie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMovieLength);
            this.Controls.Add(this.textBoxMovieName);
            this.Controls.Add(this.textBoxAllMovies);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTimeDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFinishTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStartTime);
            this.Name = "ScheduleForm";
            this.Text = "Add Movie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStartTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFinishTime;
        private System.Windows.Forms.TextBox textBoxTimeDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAllMovies;
        private System.Windows.Forms.TextBox textBoxMovieName;
        private System.Windows.Forms.TextBox textBoxMovieLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddMovie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSchedule;
        private System.Windows.Forms.Button buttonGenerateSchedule;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonDelete;
    }
}

