using Microsoft.AspNetCore.Mvc;

namespace Portals.Controllers
{
    public class PortalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
