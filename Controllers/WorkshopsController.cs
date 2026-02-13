using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class WorkshopsController : Controller
    {
        private static List<Rsvp> _registrations = new List<Rsvp>();

        public IActionResult Index()
        {
            var rsvp = new Rsvp();
            return View(rsvp);
        }

        public IActionResult RsvpForm()
        {
            return View(new Rsvp());
        }

        [HttpPost]
        public IActionResult Confirm(Rsvp model)
        {
            if (ModelState.IsValid)
            {
                _registrations.Add(model);
                ViewData["Message"] = $"Thanks for registering, {model.FullName}!";
                return View(model);
            }

            return View("RsvpForm", model);
        }

        public IActionResult Registrations()
        {
            return View(_registrations);
        }
    }
}
