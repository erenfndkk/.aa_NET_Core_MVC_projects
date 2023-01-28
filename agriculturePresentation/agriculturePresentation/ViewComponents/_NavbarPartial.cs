using Microsoft.AspNetCore.Mvc;

namespace agriculturePresentation.ViewComponents
{
	public class _NavbarPartial : ViewComponent
    {
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
