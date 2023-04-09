using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChristmasProgram.Controller
{
    public class LoginController
    {
        public bool IsUserAdmin(string txtBoxEmail, string txtBoxPassword)
        {
            bool isLoggedAsAdmin = false;
            if (txtBoxEmail == "admin@abv.bg" && txtBoxPassword == "admin")
            {
                isLoggedAsAdmin = true;
            }
            return isLoggedAsAdmin;
        }

        public string IsUserLogged(string txtBoxEmail, string txtBoxPassword)
        {
            using (SqlConnection con = new SqlConnection("Data Source=HRUSTIAN;Initial Catalog=BalskiDB;Integrated Security=True;Pooling=False"))
            {
                string message = null;
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM AccTable WHERE Email = @Email AND Password = @Password", con);
                cmd.Parameters.AddWithValue("Email", txtBoxEmail);
                cmd.Parameters.AddWithValue("Password", txtBoxPassword);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    MessageBox.Show("Succsesfully logged!");
                    MainView mv = new MainView();
                    mv.ShowDialog();
                    Application.Exit();
                }
                return message;
            }
        }
    }
}
