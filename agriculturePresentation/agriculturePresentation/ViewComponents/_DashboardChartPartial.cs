using Microsoft.AspNetCore.Mvc;

namespace agriculturePresentation.ViewComponents
{
    public class _DashboardChartPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = 33;
            ViewBag.v2 = 86;
            return View();
        }
    }
}
