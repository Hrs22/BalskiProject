using ChristmasProgram.View;
using System;
using System.Windows.Forms;

namespace ChristmasProgram
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }
        private void txtBoxHoverText_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(txtBoxHoverText, "League of Legends, Minecraft, Terraria, FIFa2023, Undertale, Dead Cells");
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
            this.Close();
        }
        private void btnGoPurchase_Click(object sender, EventArgs e)
        {
            GameShopView sv = new GameShopView();
            this.Hide();
            sv.ShowDialog();
            this.Close();
        }

        private void txtBoxHoverText2_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(txtBoxHoverText2, "Star Wars, Harry Potter, The Avengers, Men in Black, Avatar, X-Men, Titanic");
        }

        private void btnGoFilmStore_Click(object sender, EventArgs e)
        {
            FIlmShopView fv = new FIlmShopView();
            this.Hide();
            fv.ShowDialog();
            this.Close();
        }
    }
}
