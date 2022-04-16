using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlannerPiton.BusinessLayer.Concrete;
using PlannerPiton.DataAccessLayer.EntityFramework;
using PlannerPiton.EntityLayer.Concrete;
using PlannerPiton.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PlannerPiton.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        EventManager em = new EventManager(new EfEventRepository());

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public ActionResult EditEvent(int id)
        {
            var edityvalue = em.GetByID(id);
            return View(edityvalue);

        }
        [HttpPost]
        public ActionResult EditEvent(Event e)
        {
            em.EventUpdate(e);
            return RedirectToAction("Index");

        }
    }
}
