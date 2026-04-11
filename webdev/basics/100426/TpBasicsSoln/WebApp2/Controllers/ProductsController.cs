using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System.Net.Mime;
namespace WebApp2.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int? id, int? id2)
        {
            return new ContentResult()
            {
                Content = string.Format("[{0},{1}]", id.ToString(), id2.ToString())
            };
        }
        public IActionResult Details2(int id)
        {
            return new ContentResult()
            {
                Content = id.ToString(),
                ContentType = MediaTypeNames.Text.Plain
            };
        }



    }
}
