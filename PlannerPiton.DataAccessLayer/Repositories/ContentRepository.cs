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
    public class ContentRepository : IGenericDal<Content>
    {
        Context c = new Context();
        public void Insert(Content content)
        {
            c.Add(content);
            c.SaveChanges();
        }

        public void Delete(Content content)
        {
            c.Remove(content);
            c.SaveChanges();
        }

        public Content GetByID(int id)
        {
            return c.Contents.Find(id);
        }

        public List<Content> GetListAll()
        {
            return c.Contents.ToList();
        }

        public void Update(Content content)
        {
            c.Update(content);
            c.SaveChanges();
        }
    }
}
