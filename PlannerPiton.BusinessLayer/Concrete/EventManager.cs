using PlannerPiton.BusinessLayer.Abstract;
using PlannerPiton.DataAccessLayer.Abstract;
using PlannerPiton.DataAccessLayer.EntityFramework;
using PlannerPiton.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerPiton.BusinessLayer.Concrete
{
    public class EventManager : IEventService
    {
        IEventDal _eventDal;
        public EventManager()
        {
            _eventDal = new EfEventRepository();
        }

        public EventManager(IEventDal eventDal)
        {
            _eventDal = eventDal;
        }

        public void AddEvent(Event e)
        {
            _eventDal.Insert(e);
        }

        public void EventDelete(Event e)
        {
            _eventDal.Delete(e);
        }

        public void EventUpdate(Event e)
        {
            _eventDal.Update(e);
        }

        public Event GetByID(int id)
        {
            return _eventDal.GetByID(id);
        }

        public List<Event> GetList()
        {
            return _eventDal.GetListAll();
        }
    }
}
