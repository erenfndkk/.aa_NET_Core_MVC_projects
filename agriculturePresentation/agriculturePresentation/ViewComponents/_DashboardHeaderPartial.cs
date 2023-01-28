using Microsoft.AspNetCore.Mvc;

namespace agriculturePresentation.ViewComponents
{
    public class _DashboardHeaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
