using BusinessLayer.Concreate;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        public IActionResult Index()
        {
            var values = productManager.GetList();
            return View( values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            ProductValidatior validationRules = new ProductValidatior();
            ValidationResult results = validationRules.Validate(p);

            if (results.IsValid)
            {
                productManager.TInsert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteProduct(int id)
        {
            var value = productManager.GetById(id);
            productManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = productManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product p)
        {
            //var value = productManager.GetById(p.Id);
            productManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
