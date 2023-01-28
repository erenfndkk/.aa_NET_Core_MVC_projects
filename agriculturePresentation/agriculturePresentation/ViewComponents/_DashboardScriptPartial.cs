using Microsoft.AspNetCore.Mvc;

namespace agriculturePresentation.ViewComponents
{
    public class _DashboardScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
