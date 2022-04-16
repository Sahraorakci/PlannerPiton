using Microsoft.AspNetCore.Mvc;
using PlannerPiton.BusinessLayer.Abstract;
using PlannerPiton.BusinessLayer.Concrete;
using PlannerPiton.BusinessLayer.ValidationRules;
using PlannerPiton.DataAccessLayer.EntityFramework;
using PlannerPiton.EntityLayer.Concrete;
using PlannerPiton.EntityLayer.DTO;
using PlannerPiton.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlannerPiton.Web.Controllers
{
    public class CalendarController : Controller
    {
        EventManager em = new EventManager(new EfEventRepository());
        private readonly IEventService _eventService;

        public CalendarController(IEventService _p)
        {
            _eventService = _p;
        }

        public IActionResult Index()
        {
            CalendarPageModel calendarPageModel = new()
            {
                Events = _eventService.GetList()
            };
            return View(calendarPageModel);
        }

        public JsonResult GetCalendarEvents()
        {
            var eventList = _eventService.GetList();

            return Json(eventList);
        }
        [HttpGet]
        public ActionResult AddEvent()
        {
            return View();
        }
        public ActionResult DeleteEvent(int id)
        {
            var eventvalue = em.GetByID(id);
            em.EventDelete(eventvalue);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult AddEvent(Event p)
        {
                em.AddEvent(p);
                return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult EditEvent(int id)
        {
            var eventvalue = em.GetByID(id);
            return View(eventvalue);

        }
        [HttpPost]
        public ActionResult EditEvent(Event e)
        {
            em.EventUpdate(e);
            return RedirectToAction("Index");
        }
    }
}
