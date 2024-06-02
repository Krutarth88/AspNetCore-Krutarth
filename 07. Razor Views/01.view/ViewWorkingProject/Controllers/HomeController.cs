using Microsoft.AspNetCore.Mvc;

namespace ViewWorkingProject.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        public IActionResult Index()
        {
            return View(); //Views/Home/Index.cshtml
            //return new ViewResult() { ViewName = "abc" };
        }
    }
}
