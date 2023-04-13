using BalskiProject.Controller;
using BalskiProject.Utilities;
using System;
using System.Windows.Forms;

namespace BalskiProject.View
{
    public partial class FavouritesView : Form
    {
        private static FavsController favsController = new FavsController();
        public FavouritesView()
        {
            InitializeComponent();
        }

        private void FavouritesView_Load(object sender, EventArgs e)
        {
            txtBoxHelloSir.Text += LoggedUserData.Email;
            var favs = favsController.GetUserFavs(LoggedUserData.Id);

            for (int v = 0; v < favs.Count; v++)
            {
                txtBoxFavs.Text += $"{v + 1}. {favs[v]} \n";
            }

            txtBoxFavs.Text = txtBoxFavs.Text.TrimEnd();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainView mv = new MainView();
            mv.Show();
            this.Hide();
            this.Close();
        }
    }
}
