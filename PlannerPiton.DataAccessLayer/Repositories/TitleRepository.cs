using PlannerPiton.DataAccessLayer.Abstract;
using PlannerPiton.DataAccessLayer.Concrete;
using PlannerPiton.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerPiton.DataAccessLayer.Repositories
{
    class TitleRepository : ITitleDal
    {
        Context c = new Context();
        public void AddTitle(ITitleDal title)
        {
            c.Add(title);
            c.SaveChanges();
        }

        public void DeleteTitle(Title title)
        {
            c.Remove(title);
            c.SaveChanges();
        }

        public Title GetById(int id)
        {
            return c.Titles.Find(id);
        }

        public List<Title> ListAllTitle()
        {
            return c.Titles.ToList();
        }

        public void UpdateTitle(Title title)
        {
            c.Update(title);
            c.SaveChanges();
        }
    }
}
