using Microsoft.AspNetCore.Mvc;

namespace Introspective.Web.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
