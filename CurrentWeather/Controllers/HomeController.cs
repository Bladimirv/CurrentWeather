using System.Web.Mvc;

namespace CurrentWeather.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ver(int id)
        {
            //Go Details
            return RedirectToAction("Details", "CurrentWheather", new { id = id});
        }
    }
}