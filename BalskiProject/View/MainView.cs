using BalskiProject.View;
using System;
using System.Windows.Forms;

namespace BalskiProject
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }
        private void btnChanceAcc_Click(object sender, EventArgs e)
        {
            LoginView lv = new LoginView();
            this.Hide();
            lv.ShowDialog();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnGoFilmStore_Click(object sender, EventArgs e)
        {
            TodaysMovieView fv = new TodaysMovieView();
            fv.Show();
            this.Hide();
            this.Close();
        }

        private void btnGoTvWeekly_Click(object sender, EventArgs e)
        {
            TodaysTvShowsView sv = new TodaysTvShowsView();
            sv.Show();
            this.Hide();
        }

        private void btnGoTvDaily_Click(object sender, EventArgs e)
        {
            TodaysTvShowsView sv = new TodaysTvShowsView();
            sv.Show();
            this.Hide();
        }

        private void btnGoWeeklyMovies_Click(object sender, EventArgs e)
        {
            WeeklyMovieView fv = new WeeklyMovieView();
            fv.Show();
            this.Hide();
            this.Close();
        }
    }
}
