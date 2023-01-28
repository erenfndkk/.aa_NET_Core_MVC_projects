using BusinessLayer.Concreate;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class JobController : Controller
    {
        JobManager jobManager = new JobManager(new EfJobDal());
        public IActionResult Index()
        {
            var values = jobManager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddJob()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddJob(Job p)
        {

            
            jobManager.TInsert(p);
            return RedirectToAction("Index");
            
       
        }
        public IActionResult DeleteJob(int id)
        {
            var value = jobManager.GetById(id);
            jobManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateJob(int id)
        {
            var value = jobManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateJob(Job p)
        {
            //var value = productManager.GetById(p.Id);
            jobManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
