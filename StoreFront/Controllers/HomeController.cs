using System.Web.Mvc;
//***On my project, identity/identitysamples issue that we had to fix (OWIN) in the web.config :
//appSetting owin:AutomaticAppStartup with a value of "false" ***

namespace StoreFront.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        //[Authorize] --this was automatically in the HomeController, but my pages won't load with this
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Gallery()
        {
            ViewBag.Message = "Your gallery page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
