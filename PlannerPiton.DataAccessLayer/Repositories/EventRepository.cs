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
        public void AddEvent(Event e)
        {
            c.Add(e);
            c.SaveChanges();
        }

        public void DeleteEvent(Event e)
        {
            c.Remove(e);
            c.SaveChanges();
        }

        public Event GetById(int id)
        {
            return c.Events.Find(id);
        }

        public List<Event> ListAllEvent()
        {
            return c.Events.ToList();
        }

        public void UpdateEvent(Event e)
        {
            c.Update(e);
            c.SaveChanges();
        }
    }
}
