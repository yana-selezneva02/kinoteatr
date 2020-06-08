using System.Web.Mvc;

namespace Cinema.Controllers
{
    public class CinemaController : Controller
    {
        public ActionResult Index()
        {
            return View();
          
        }
    }
}