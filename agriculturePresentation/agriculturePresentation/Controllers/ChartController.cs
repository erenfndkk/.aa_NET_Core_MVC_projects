using agriculturePresentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace agriculturePresentation.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductChart()
        {
            List<ProductClass> productClasses = new List<ProductClass>();

            productClasses.Add(new ProductClass
            {
                productname = "Buğday",
                productvalue = 750
            });

            productClasses.Add(new ProductClass
            {
                productname = "Mercimek",
                productvalue = 350
            });

            productClasses.Add(new ProductClass
            {
                productname = "Arpa",
                productvalue = 450
            });

            productClasses.Add(new ProductClass
            {
                productname = "Pirinç",
                productvalue = 550
            });

            productClasses.Add(new ProductClass
            {
                productname = "Domates",
                productvalue = 650
            });
            return Json(new {jsonlist = productClasses});
        }
    }
}
