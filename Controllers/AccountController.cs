using Microsoft.AspNetCore.Mvc;

namespace Elykp.IdentityServer.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public string Hello()
        {
            return "Hello world";
        }
    }
}
