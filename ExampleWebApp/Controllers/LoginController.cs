using System.Web.Mvc;

namespace ExampleWebApp.Controllers.Examples
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("~/Views/Login.cshtml");
        }
    }
}
