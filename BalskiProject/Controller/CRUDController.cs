using BalskiProject.Data.Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BalskiProject.Controller
{
    public class CRUDController
    {
        public void Register(string txtBoxEnterEmail, string txtBoxEnterPassword)
        {
            using (BalskiDbContexEntities BalskiContext = new BalskiDbContexEntities())
            {
                var lastUser = BalskiContext.AccTables.ToList().LastOrDefault();
                int lastId;
                if (lastUser is null)
                {
                    lastId = 1;
                }
                else
                {
                    lastId = lastUser.Id + 1;
                }
                BalskiContext.AccTables.Add(new AccTable
                {
                    Id = lastId,
                    Email = txtBoxEnterEmail,
                    Password = txtBoxEnterPassword
                });
                BalskiContext.SaveChanges();
            }
        }

        public bool DeleteUser(string txtBoxEnterEmail, string txtBoxEnterPassword)
        {
            using (BalskiDbContexEntities BalskiContext = new BalskiDbContexEntities())
            {
                var userToDelete = BalskiContext.AccTables
                .Where(u => u.Email == txtBoxEnterEmail && u.Password == txtBoxEnterPassword)
                .FirstOrDefault();

                if (userToDelete != null)
                {
                    BalskiContext.AccTables.Remove(userToDelete);
                    BalskiContext.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public List<AccTable> AllAccounts()
        {
            using (BalskiDbContexEntities BalskiContext = new BalskiDbContexEntities())
            {
                return BalskiContext.AccTables.ToList();
            }
        }
    }
}
