using Microsoft.AspNetCore.Mvc;

namespace agriculturePresentation.ViewComponents
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
