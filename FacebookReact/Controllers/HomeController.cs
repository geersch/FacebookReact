using System.Web.Mvc;

namespace FacebookReact.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult HelloWorldJsx()
        {
            return View();
        }

        public ActionResult HelloWorldNoJsx()
        {
            return View();
        }

        public ActionResult Component()
        {
            return View();
        }

        public ActionResult StatefulComponent()
        {
            return View();
        }

        public ActionResult MultipleComponents()
        {
            return View();
        }

        public ActionResult Application()
        {
            return View();
        }
    }
}