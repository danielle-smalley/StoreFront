using System.Web.Mvc;
//***On my project, identity/identitysamples issue that we had to fix (OWIN) :
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
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

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
