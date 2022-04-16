using PlannerPiton.EntityLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlannerPiton.Web.Models
{
    public class CalendarPageModel
    {
       public List<EventDTO> Events { get; set; }
    }
}
