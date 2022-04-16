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
        public void Insert(Title title)
        {
            c.Add(title);
            c.SaveChanges();
        }

        public void Delete(Title title)
        {
            c.Remove(title);
            c.SaveChanges();
        }

        public Title GetByID(int id)
        {
            return c.Titles.Find(id);
        }

        public List<Title> GetListAll()
        {
            return c.Titles.ToList();
        }

        public void Update(Title title)
        {
            c.Update(title);
            c.SaveChanges();
        }
    }
}
