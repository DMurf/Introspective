using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web;

namespace Introspective.Web.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoginUp()
        {
            var referrer = Request.Headers["Referer"].ToString();
            if (!string.IsNullOrWhiteSpace(referrer))
            {
                HttpContext.Session.SetString("PostLoginRedirect", referrer);
            }

            return Redirect("/MicrosoftIdentity/Account/SignIn?redirectUri=/Configure");
        }


        [HttpGet]
        [Route("/Configure")]
        public IActionResult Setup()
        {
            var uID = User.GetObjectId();
            if (User.Claims.Any(x => x.Type == "emails"))
            {
                var email = User.FindFirst("emails");
            }

            if (User.Claims.Any(x => x.Type == "newUser"))
            {
                // User is new!
            }

            var redirect = HttpContext.Session.GetString("PostLoginRedirect");
            if (!string.IsNullOrEmpty(redirect))
            {
                return Redirect(redirect);
            }

            return RedirectToAction("Index", "Home");
        }

        [Route("/Profile/SignedOut")]
        [Route("/Profile/Gone")]
        public IActionResult SignedOut()
        {
            return View();
        }
    }
}
