using System.Web.Mvc;
using TripItinerary.Models;

namespace TripItinerary.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new Trip());
        }
    }
}