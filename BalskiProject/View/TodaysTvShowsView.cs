using BalskiProject.Controller;
using BalskiProject.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TMDbLib.Client;
using TMDbLib.Objects.Search;
using TMDbLib.Objects.Trending;
using TMDbLib.Objects.TvShows;

namespace BalskiProject.View
{
    public partial class TodaysTvShowsView : Form
    {
        private static List<SearchTv> trendingTvSeries;
        private static FavsController controller = new FavsController();
        public TodaysTvShowsView()
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
            t_Tip.SetToolTip(picBoxTv1, trendingTvSeries[0].Overview);
        }

        private void picBox2_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxTv2, trendingTvSeries[1].Overview);
        }

        private void picBox3_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxTv3, trendingTvSeries[2].Overview);
        }

        private void picBox4_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxTv4, trendingTvSeries[3].Overview);
        }

        private void picBox5_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxTv5, trendingTvSeries[4].Overview);
        }

        private void picBox6_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxTv6, trendingTvSeries[5].Overview);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainView mv = new MainView();
            mv.Show();
            this.Hide();
            this.Close();
        }
        private void TvShowsView_Load(object sender, EventArgs e)
        {
            List<PictureBox> picBoxes = new List<PictureBox>()
            {
                picBoxTv1, picBoxTv2, picBoxTv3,
                picBoxTv4, picBoxTv5, picBoxTv6,
            };

            TMDbClient client = new TMDbClient("2b35868071ac8e7771bb73426a9f9386");
            _ = client.GetConfigAsync().Result;

            trendingTvSeries = client.GetTrendingTvAsync(TimeWindow.Day).Result.Results;

            for (int i = 0; i < 6; i++)
            {
                TvShow tv = client.GetTvShowAsync(trendingTvSeries[i].Id).Result;
                byte[] bytes = client.GetImageBytesAsync("original", tv.PosterPath).Result;
                MemoryStream ms = new MemoryStream(bytes);
                Image img = Image.FromStream(ms);
                picBoxes[i].Image = img;
            }
        }

        private void btnVisit1_Click(object sender, EventArgs e)
        {
            Process.Start($"https://www.google.com/search?q={trendingTvSeries[0].Name}");
        }

        private void btnVisit2_Click(object sender, EventArgs e)
        {
            Process.Start($"https://www.google.com/search?q={trendingTvSeries[1].Name}");
        }

        private void btnVisit3_Click(object sender, EventArgs e)
        {
            Process.Start($"https://www.google.com/search?q={trendingTvSeries[2].Name}");
        }

        private void btnVisit4_Click(object sender, EventArgs e)
        {
            Process.Start($"https://www.google.com/search?q={trendingTvSeries[3].Name}");
        }

        private void btnVisit5_Click(object sender, EventArgs e)
        {
            Process.Start($"https://www.google.com/search?q={trendingTvSeries[4].Name}");
        }

        private void btnVisit6_Click(object sender, EventArgs e)
        {
            Process.Start($"https://www.google.com/search?q={trendingTvSeries[5].Name}");
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            WeeklyTvShowsView vm = new WeeklyTvShowsView();
            vm.Show();
            this.Hide();
            this.Close();
        }

        private void picBoxHearth1_Click(object sender, EventArgs e)
        {
            controller.AddFav(trendingTvSeries[0].Name, LoggedUserData.Id);
            MessageBox.Show("Sucsessfully added to favourites", "FAVOURITES UPDATE",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picBoxHearth2_Click(object sender, EventArgs e)
        {
            controller.AddFav(trendingTvSeries[1].Name, LoggedUserData.Id);
            MessageBox.Show("Sucsessfully added to favourites", "FAVOURITES UPDATE",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picBoxHearth3_Click(object sender, EventArgs e)
        {
            controller.AddFav(trendingTvSeries[2].Name, LoggedUserData.Id);
            MessageBox.Show("Sucsessfully added to favourites", "FAVOURITES UPDATE",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picBoxHearth4_Click(object sender, EventArgs e)
        {
            controller.AddFav(trendingTvSeries[3].Name, LoggedUserData.Id);
            MessageBox.Show("Sucsessfully added to favourites", "FAVOURITES UPDATE",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picBoxHearth5_Click(object sender, EventArgs e)
        {
            controller.AddFav(trendingTvSeries[4].Name, LoggedUserData.Id);
            MessageBox.Show("Sucsessfully added to favourites", "FAVOURITES UPDATE",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picBoxHearth6_Click(object sender, EventArgs e)
        {
            controller.AddFav(trendingTvSeries[5].Name, LoggedUserData.Id);
            MessageBox.Show("Sucsessfully added to favourites", "FAVOURITES UPDATE",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
