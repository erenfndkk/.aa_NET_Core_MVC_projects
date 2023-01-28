using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace agriculturePresentation.ViewComponents
{
    public class _MapPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            agricultureContext agriculturecontext = new agricultureContext();
            var values = agriculturecontext.Adresses.Select(x => x.Mapinfo).FirstOrDefault();
            ViewBag.v = values;
            return View();
        }
    }
}
