using BalskiProject.Controller;
using BalskiProject.Utilities;
using System;
using System.Windows.Forms;

namespace BalskiProject.View
{
    public partial class AdminMainView : Form
    {
        CRUDController CrudController = new CRUDController();
        public AdminMainView()
        {
            InitializeComponent();
        }
        private void LoadAccount()
        {
            dgv.DataSource = CrudController.AllAccounts();
        }

        private void AdminMainView_Load(object sender, EventArgs e)
        {
            LoadAccount();
        }
        private void txtBoxEmail_MouseHover(object sender, EventArgs e)
        {
            txtBoxEmail.Clear();
        }

        private void txtBoxEmail_MouseClick(object sender, MouseEventArgs e)
        {
            txtBoxEmail.Clear();
        }

        private void txtBoxPassword_MouseHover(object sender, EventArgs e)
        {
            txtBoxPassword.Clear();
        }

        private void txtBoxPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtBoxPassword.Clear();
        }

        private void btnAddUser_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.Info;
            t_Tip.SetToolTip(btnAddUser, "This button adds a user to the database!");
        }

        private void btnRemoveUser_MouseHover(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.Info;
            t_Tip.SetToolTip(btnRemoveUser, "This button remove user from the database!");
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (Validator.EmptyString(txtBoxEmail.Text) || Validator.EmptyString(txtBoxPassword.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else
            {
                CrudController.Register(txtBoxEmail.Text, txtBoxPassword.Text);
                Clear();

                void Clear()
                {
                    txtBoxEmail = null;
                    txtBoxPassword = null;
                }
                MessageBox.Show("Succsesfully added user!");

            }
        }
        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (Validator.EmptyString(txtBoxEmail.Text) || Validator.EmptyString(txtBoxPassword.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else
            {
                CrudController.DeleteUser(txtBoxEmail.Text, txtBoxPassword.Text);
                LoadAccount();
            }
        }
    }
}
