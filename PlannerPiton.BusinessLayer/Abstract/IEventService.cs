using PlannerPiton.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerPiton.BusinessLayer.Abstract
{
    public interface IEventService
    {
        void AddEvent(Event e);
        void EventDelete(Event e);
        void EventUpdate(Event e);
        List<Event> GetList();
        Event GetByID(int id);
    }
}
