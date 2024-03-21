using Microsoft.AspNetCore.Mvc;

namespace Introspective.Web.Controllers
{
    public class BoardsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
