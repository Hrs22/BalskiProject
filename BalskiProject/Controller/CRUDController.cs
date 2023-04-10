using BalskiProject.Data.Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ChristmasProgram.Controller
{
    public class CRUDController
    {
        public void Register(string txtBoxEnterEmail, string txtBoxEnterPassword)
        {
            using (BalskiDbContexEntities BalskiContext = new BalskiDbContexEntities())
            {
                int? lastId = BalskiContext.AccTables.ToList().LastOrDefault().Id;

                if (lastId is null)
                {
                    lastId = 1;
                }
                BalskiContext.AccTables.Add(new AccTable
                {
                    Id = (int)(++lastId),
                    Email = txtBoxEnterEmail,
                    Password = txtBoxEnterPassword
                });
                BalskiContext.SaveChanges();
            }
        }

        public void DeleteUser(string txtBoxEnterEmail, string txtBoxEnterPassword)
        {
            using (BalskiDbContexEntities BalskiContext = new BalskiDbContexEntities())
            {
                var userToDelete = BalskiContext.AccTables
                .Where(u => u.Email == txtBoxEnterEmail && u.Password == txtBoxEnterPassword)
                .First();

                BalskiContext.AccTables.Remove(userToDelete);
                BalskiContext.SaveChanges();
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
