using BalskiProject.Controller;
using BalskiProject.Utilities;
using System;
using System.Windows.Forms;

namespace BalskiProject.View
{
    public partial class LoginView : Form
    {
        CRUDController CrudController = new CRUDController();
        LoginController LoginController = new LoginController();
        public LoginView()
        {
            InitializeComponent();
        }
        private void txtBoxEmail_MouseClick(object sender, MouseEventArgs e)
        {
            txtBoxEmail.Clear();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (Validator.EmptyString(txtBoxEmail.Text) || Validator.EmptyString(txtBoxPassword.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!Validator.EmailLenght(txtBoxEmail.Text))
            {
                MessageBox.Show("The lenght of the Email should be between 8 and 18", "INVALID EMAIL",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Validator.IsValidEmail(txtBoxEmail.Text))
            {
                MessageBox.Show("Your email is missing something!", "INVALID EMAIL",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Validator.PasswordLength(txtBoxPassword.Text))
            {
                MessageBox.Show("The lenght of the Password should be between 4 and 12", "INVALID PASSWORD",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var adminPassword = LoginController.IsUserAdmin(txtBoxEmail.Text, txtBoxPassword.Text);
            var message = LoginController.IsUserLogged(txtBoxEmail.Text, txtBoxPassword.Text);
            if (adminPassword)
            {
                MessageBox.Show("Succsesfully logged into Admin!");
                AdminMainView adminMainView = new AdminMainView();
                adminMainView.Show();
                this.Hide();
            }
            else if (message == "Successfuly logged!")
            {
                MainView mv = new MainView();
                mv.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Something went wrong!");
            }
        }
        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            RegisterView rv = new RegisterView();
            this.Hide();
            rv.Show();
        }
        private void btnCantLog_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Enter your email address. \n[Must include 8-18 characters and the '@' symbol]\n\n" +
                "2. Enter your password. \n[Must include 4-12 characters]\n\n" +
                "3. Click the “Log in” button. ", "INFORMATION",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtBoxEmail_MouseHover(object sender, EventArgs e)
        {
            txtBoxEmail.Clear();
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.Info;
            t_Tip.SetToolTip(txtBoxEmail, "Email should start with Capital letter!");
        }

        private void btnAreYouAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter the admin email and password.");
        }

        private void OnFocus(object sender, EventArgs e)
        {
            txtBoxPassword.PasswordChar = '*';
        }

        private void txtBoxPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtBoxPassword.Clear();
            this.txtBoxPassword.GotFocus += OnFocus;
        }
        private void txtBoxPassword_MouseHover(object sender, EventArgs e)
        {
            txtBoxPassword.Clear();
            this.txtBoxPassword.GotFocus += OnFocus;
        }
        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {

            this.txtBoxPassword.GotFocus += OnFocus;
        }
    }
}
