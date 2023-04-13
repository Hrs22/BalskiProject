using BalskiProject.Controller;
using BalskiProject.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TMDbLib.Client;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Search;
using TMDbLib.Objects.Trending;

namespace BalskiProject.View
{
    public partial class TodaysMovieView : Form
    {
        private static List<SearchMovie> trendingMovies;
        private static FavsController controller = new FavsController();
        public TodaysMovieView()
        {
            InitializeComponent();
        }

        private void picBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxMovie1, trendingMovies[0].Overview);
        }

        private void picBox2_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxMovie2, trendingMovies[1].Overview);
        }

        private void picBox3_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxMovie3, trendingMovies[2].Overview);
        }

        private void picBox4_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxMovie4, trendingMovies[3].Overview);
        }

        private void picBox5_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxMovie5, trendingMovies[4].Overview);
        }

        private void picBox6_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxMovie6, trendingMovies[5].Overview);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainView mv = new MainView();
            mv.Show();
            this.Hide();
            this.Close();
        }
        private void FIlmShopView_Load(object sender, EventArgs e)
        {
            List<PictureBox> picBoxes = new List<PictureBox>()
            {
                picBoxMovie1, picBoxMovie2, picBoxMovie3,
                picBoxMovie4, picBoxMovie5, picBoxMovie6,
            };

            TMDbClient client = new TMDbClient("2b35868071ac8e7771bb73426a9f9386");
            _ = client.GetConfigAsync().Result;

            trendingMovies = client.GetTrendingMoviesAsync(TimeWindow.Day).Result.Results;

            for (int i = 0; i < 6; i++)
            {
                Movie movie = client.GetMovieAsync(trendingMovies[i].Id).Result;
                byte[] bytes = client.GetImageBytesAsync("original", movie.PosterPath).Result;
                MemoryStream ms = new MemoryStream(bytes);
                Image img = Image.FromStream(ms);
                picBoxes[i].Image = img;
            }
        }

        private void btnVisit1_Click(object sender, EventArgs e)
        {
            Process.Start($"https://www.google.com/search?q={trendingMovies[0].Title}");
        }

        private void btnVisit2_Click(object sender, EventArgs e)
        {
            Process.Start($"https://www.google.com/search?q={trendingMovies[1].Title}");
        }

        private void btnVisit3_Click(object sender, EventArgs e)
        {
            Process.Start($"https://www.google.com/search?q={trendingMovies[2].Title}");
        }

        private void btnVisit4_Click(object sender, EventArgs e)
        {
            Process.Start($"https://www.google.com/search?q={trendingMovies[3].Title}");
        }

        private void btnVisit5_Click(object sender, EventArgs e)
        {
            Process.Start($"https://www.google.com/search?q={trendingMovies[4].Title}");
        }

        private void btnVisit6_Click(object sender, EventArgs e)
        {
            Process.Start($"https://www.google.com/search?q={trendingMovies[5].Title}");
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            WeeklyMovieView mv = new WeeklyMovieView();
            mv.Show();
            this.Hide();
            this.Close();
        }

        private void picBoxHearth1_Click(object sender, EventArgs e)
        {
            controller.AddFav(trendingMovies[0].Title, LoggedUserData.Id);
            MessageBox.Show("Sucsessfully added to favourites", "FAVOURITES UPDATE",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picBoxHearth2_Click(object sender, EventArgs e)
        {
            controller.AddFav(trendingMovies[1].Title, LoggedUserData.Id);
            MessageBox.Show("Sucsessfully added to favourites", "FAVOURITES UPDATE",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picBoxHearth3_Click(object sender, EventArgs e)
        {
            controller.AddFav(trendingMovies[2].Title, LoggedUserData.Id);
            MessageBox.Show("Sucsessfully added to favourites", "FAVOURITES UPDATE",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picBoxHearth4_Click(object sender, EventArgs e)
        {
            controller.AddFav(trendingMovies[3].Title, LoggedUserData.Id);
            MessageBox.Show("Sucsessfully added to favourites", "FAVOURITES UPDATE",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picBoxHearth5_Click(object sender, EventArgs e)
        {
            controller.AddFav(trendingMovies[4].Title, LoggedUserData.Id);
            MessageBox.Show("Sucsessfully added to favourites", "FAVOURITES UPDATE",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picBoxHearth6_Click(object sender, EventArgs e)
        {
            controller.AddFav(trendingMovies[5].Title, LoggedUserData.Id);
            MessageBox.Show("Sucsessfully added to favourites", "FAVOURITES UPDATE",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
