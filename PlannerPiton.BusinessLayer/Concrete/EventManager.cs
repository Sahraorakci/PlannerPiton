using PlannerPiton.BusinessLayer.Abstract;
using PlannerPiton.DataAccessLayer.Abstract;
using PlannerPiton.DataAccessLayer.EntityFramework;
using PlannerPiton.EntityLayer.Concrete;
using PlannerPiton.EntityLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public List<EventDTO> GetList()
        {
            Expression<Func<Event, bool>> expEvent = c => true;

            var list = _eventDal.GetListAll();

            var dtoList = list.Select(p => new EventDTO
            {
                Id = p.EventID,
                title = p.Name,
                end = p.EndDate,
                start = p.StartDate,
                color = p.BackgroundColor,
                allDay = p.AllDay
            }).ToList();

            return dtoList;
        }
    }
}
