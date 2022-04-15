using PlannerPiton.BusinessLayer.Abstract;
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
        EfEventRepository efEventRepository;
        public EventManager()
        {
            efEventRepository = new EfEventRepository();
        }
        public void AddEvent(Event e)
        {
            efEventRepository.Insert(e);
        }

        public void EventDelete(Event e)
        {
            efEventRepository.Delete(e);
        }

        public void EventUpdate(Event e)
        {
            efEventRepository.Update(e);
        }

        public Event GetByID(int id)
        {
            return efEventRepository.GetByID(id);
        }

        public List<Event> GetList()
        {
            return efEventRepository.GetListAll();
        }
    }
}
