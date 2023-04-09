using System;
using System.Windows.Forms;

namespace ChristmasProgram.View
{
    public partial class GameShopView : Form
    {
        public GameShopView()
        {
            InitializeComponent();
        }

        private void picBoxLOL_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxLOL, "League of Legends, commonly referred to as League, is a 2009 multiplayer online battle arena video game developed and published by Riot Games. Inspired by Defense of the Ancients," +
                " a custom map for Warcraft III, Riot's founders sought to develop a stand-alone game in the same genre.");
        }

        private void picBoxTerraria_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxTerraria, "Dig, fight, explore, build! Nothing is impossible in this action-packed adventure game." +
                "The world is your canvas and the ground itself is your paint.");
        }

        private void picBoxMinecraft_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxMinecraft, "With new games, new updates, and new ways to play, join one of the biggest communities in gaming and start crafting today!");
        }

        private void picBoxFiFa_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxFiFa, "EA SPORTS™ FIFA 23 brings The World's Game to the pitch, with next-gen ... the UEFA Women's Champions League knockout stage coming to FIFA 23 in early 2023.");
        }

        private void picBoxUndertale_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxUndertale, "UNDERTALE! The RPG game where you don't have to destroy anyone.");
        }

        private void picBoxDC_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxDC, "Dead Cells is a rogue-lite, Castlevania-inspired action-platformer, allowing you to explore a sprawling, ever-changing castle… assuming you’re able to fight your way past its keepers.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainView mv = new MainView();
            this.Hide();
            mv.ShowDialog();
            this.Close();
        }

        private void btnBuyLoL_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succsessfully bought!");
        }

        private void btnBuyTerraria_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succsessfully bought!");
        }

        private void btnBuyMc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succsessfully bought!");
        }

        private void btnBuyFiFa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succsessfully bought!");
        }

        private void btnBuyUndertale_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succsessfully bought!");
        }

        private void btnBuyDC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succsessfully bought!");
        }
    }
}
