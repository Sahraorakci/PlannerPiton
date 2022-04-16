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
    class EventRepository : IEventDal
    {
        Context c = new Context();
        public void Insert(Event e)
        {
            c.Add(e);
            c.SaveChanges();
        }

        public void Delete(Event e)
        {
            c.Remove(e);
            c.SaveChanges();
        }

        public Event GetByID(int id)
        {
            return c.Events.Find(id);
        }

        public List<Event> GetListAll()
        {
            return c.Events.ToList();
        }

        public void Update(Event e)
        {
            c.Update(e);
            c.SaveChanges();
        }
    }
}
