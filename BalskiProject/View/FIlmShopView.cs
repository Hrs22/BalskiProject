using System;
using System.Windows.Forms;

namespace ChristmasProgram.View
{
    public partial class FIlmShopView : Form
    {
        public FIlmShopView()
        {
            InitializeComponent();
        }

        private void picBoxStarWars_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxStarWars, "Star Wars is an American epic space opera multimedia franchise created by George Lucas," +
                " which began with the eponymous 1977 film and quickly became a worldwide pop culture phenomenon.");
        }

        private void picBoxXMEN_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxXMEN, "The X-Men are a group created by Professor Charles Xavier as a response to the emergence of naturally occurring superhumans known as mutants among the baseline human society. Dedicated to promoting a dream of peaceful coexistence between mutants and humans, Xavier trained his X-Men in the use of their" +
                " mutant powers at the Xavier's School for Gifted Youngsters, forging them into defenders of a world that hates and fears them.");
        }

        private void picBoxMenInBlack_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxMenInBlack, "Men in Black follows the exploits of agents Kay (Jones) and Jay (Smith), members of a top-secret organization established to monitor alien activity on Earth. The two MiB find themselves in the middle of the deadly plot by" +
                " an intergalactic terrorist (Vincent D'Onofrio) who has arrived on Earth to assassinate two ambassadors from opposing galaxies.");
        }

        private void picBoxHarryPotter_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxHarryPotter, "Harry is an orphan living with his abusive aunt and uncle, Vernon and Petunia Dursley and their bullying son, Dudley. On his eleventh birthday, " +
                "Harry discovers he is a wizardwhen Rubeus Hagrid delivers him an acceptance letter to Hogwarts School of Witchcraft and Wizardry.");
        }

        private void picBoxAvatar_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxAvatar, "Pandora, whose atmosphere is inhospitable to humans, is inhabited by the Na'vi, 10-foot-tall (3.0 m), blue-skinned, sapient humanoids that live in harmony with nature. To explore Pandora, genetically matched human scientists use Na'vi-human hybrids called Avatars");
        }

        private void picBoxAvengers_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.None;
            t_Tip.SetToolTip(picBoxAvengers, "Earth's Mightiest Heroes stand as the planet's first line of defense against the most powerful threats in the universe. The Avengers began as a group of extraordinary individuals who " +
                "were assembled to defeat Loki and his Chitauri army in New York City.");
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
            MessageBox.Show("Succsessfully bought, have a nice watch!");
        }

        private void btnBuyTerraria_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succsessfully bought, have a nice watch!");
        }

        private void btnBuyMc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succsessfully bought, have a nice watch!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succsessfully bought, have a nice watch!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succsessfully bought, have a nice watch!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succsessfully bought, have a nice watch!");
        }
    }
}
