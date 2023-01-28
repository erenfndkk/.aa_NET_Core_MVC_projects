using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concreate;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace agriculturePresentation.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAdressService _adressService;

        public AddressController(IAdressService adressService)
        {
            _adressService = adressService;
        }

        public IActionResult Index()
        {
            var values = _adressService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult UpdateAddress(int id)
        {
            var value = _adressService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateAddress(Adress adress)
        {
            AddressValidatior validationRules = new AddressValidatior();
            ValidationResult result = validationRules.Validate(adress);

            if (result.IsValid)
            {
                _adressService.Update(adress);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
