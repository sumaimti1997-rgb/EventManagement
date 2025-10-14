using Microsoft.AspNetCore.Mvc;

namespace EventManagement.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
