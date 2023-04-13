using BalskiProject.Data.Model;
using System.Collections.Generic;
using System.Linq;

namespace BalskiProject.Controller
{
    public class FavsController
    {
        public List<string> GetUserFavs(int UserId)
        {
            using (BalskiDbContexEntities context = new BalskiDbContexEntities())
            {
                return context.FavsTables
                    .Where(t => t.UserId == UserId)
                    .Select(t => t.Title)
                    .ToList();
            }
        }
        public void AddFav(string title, int userId)
        {
            using (BalskiDbContexEntities context = new BalskiDbContexEntities())
            {
                if (context.FavsTables.Any(f => f.Title == title && f.UserId == userId))
                {
                    return;
                }
                var lastFav = context.FavsTables.ToList().LastOrDefault();
                int lastId;
                if (lastFav is null)
                {
                    lastId = 1;
                }
                else
                {
                    lastId = lastFav.Id + 1;
                }
                context.FavsTables.Add(new FavsTable
                {
                    Id = lastId,
                    Title = title,
                    UserId = userId
                });
                context.SaveChanges();
            }
        }
    }
}
