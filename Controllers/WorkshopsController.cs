using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class WorkshopsController : Controller
    {
        public IActionResult Index()
        {
            var rsvp = new Rsvp();
            return View(rsvp);
        }
    }
}
