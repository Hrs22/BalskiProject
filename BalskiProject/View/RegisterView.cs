using BalskiProject.Utilities;
using ChristmasProgram.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChristmasProgram.View
{
    public partial class RegisterView : Form
    {
        CRUDController CrudController = new CRUDController();
        public RegisterView()
        {
            InitializeComponent();
        }
        private void txtBoxHoverText_MouseHover(object sender, EventArgs e)
        {
            toolTipLearnThis.Show("The following information helps us verify your identity and provide you with appropriate content.", txtBoxHoverText);
            toolTipLearnThis.OwnerDraw = true;
            toolTipLearnThis.ForeColor = Color.Black;
            toolTipLearnThis.BackColor = Color.Purple;
        }
        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawText();
            e.DrawBorder();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (Validator.EmptyString(txtBoxEnterEmail.Text) || Validator.EmptyString(txtBoxEnterPassword.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (!Validator.EmailLenght(txtBoxEnterEmail.Text))
                {
                    MessageBox.Show("The lenght of the Email should be between 8 and 18", "INVALID EMAIL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!Validator.IsValidEmail(txtBoxEnterEmail.Text))
                {
                    MessageBox.Show("Your email is missing something!", "INVALID EMAIL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!Validator.PasswordLength(txtBoxEnterPassword.Text))
                {
                    MessageBox.Show("The lenght of the Password should be between 4 and 12", "INVALID PASSWORD",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                CrudController.Register(txtBoxEnterEmail.Text, txtBoxEnterPassword.Text);
                Clear();

                void Clear()
                {
                    txtBoxEnterEmail = null;
                    txtBoxEnterPassword = null;
                }
                MessageBox.Show("Succsesfully registered!", "Welcome",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChristmasProgram.MainView mv = new ChristmasProgram.MainView();
                this.Hide();
                mv.ShowDialog();
                this.Close();
            }
        }
        private void txtBoxEnterEmail_MouseHover(object sender, EventArgs e)
        {
            txtBoxEnterEmail.Clear();
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.Info;
            t_Tip.SetToolTip(txtBoxEnterEmail, "Email should start with Capital letter!");
        }

        private void txtBoxEnterPassword_MouseHover_1(object sender, EventArgs e)
        {
            txtBoxEnterPassword.Clear();
            this.txtBoxEnterPassword.GotFocus += OnFocus;
            txtBoxEnterPassword.Clear();
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.Info;
            t_Tip.SetToolTip(txtBoxEnterPassword, "Choose a strong password!");
        }

        private void OnFocus(object sender, EventArgs e)
        {
            txtBoxEnterPassword.PasswordChar = '*';
        }

        private void txtBoxEnterPassword_MouseClick_(object sender, MouseEventArgs e)
        {
            txtBoxEnterPassword.Clear();
            this.txtBoxEnterPassword.GotFocus += OnFocus;
        }
        private void txtBoxEnterEmail_MouseClick(object sender, MouseEventArgs e)
        {
            txtBoxEnterEmail.Clear();
        }
    }
}
