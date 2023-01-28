using Microsoft.AspNetCore.Mvc;

namespace agriculturePresentation.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
