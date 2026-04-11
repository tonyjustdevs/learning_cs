using Microsoft.AspNetCore.Mvc;

namespace WebApp2.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            //return new ContentResult() { Content = $"ID supplied to URL: '{id.ToString()}'" };

            
            return View();

        }

    }
}
