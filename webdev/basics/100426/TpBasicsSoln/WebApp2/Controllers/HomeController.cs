using Microsoft.AspNetCore.Mvc;

namespace WebApp2.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index() // Action methods handle requests
        public IActionResult Index()
        {
            return View();
            //return View("Index2");
        }

        public string OldIndex() // Action methods handle requests
        {
            return "gday mate from HomeController.Index()";
        }
    }
}
