using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace agriculturePresentation.ViewComponents
{
	public class _TopAddressPartial : ViewComponent
	{
		private readonly IAdressService _adressService;

		public _TopAddressPartial(IAdressService adressService)
		{
			_adressService = adressService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _adressService.GetListAll();
			return View(values);
		}
	}
}
