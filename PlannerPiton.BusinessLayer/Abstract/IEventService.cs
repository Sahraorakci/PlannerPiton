using PlannerPiton.EntityLayer.Concrete;
using PlannerPiton.EntityLayer.DTO;
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
        List<EventDTO> GetList();
        Event GetByID(int id);
    }
}
