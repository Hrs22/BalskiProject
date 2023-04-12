using BalskiProject.Data.Model;
using BalskiProject.Utilities;
using System.Linq;

namespace BalskiProject.Controller
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

        public string IsUserLogged(string Email, string Password)
        {
            using (BalskiDbContexEntities BalskiContext = new BalskiDbContexEntities())
            {
                var foundUser = BalskiContext.AccTables.FirstOrDefault(u => u.Email == Email && u.Password == Password);
                if (foundUser == null)
                {
                    return "User not found!";
                }
                LoggedUserData.Email = foundUser.Email;
                LoggedUserData.Password = foundUser.Password;
                return "Successfuly logged!";
            }
        }
    }
}
