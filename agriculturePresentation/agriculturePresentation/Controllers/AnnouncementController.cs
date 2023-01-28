using BusinessLayer.Abstract;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System;

namespace agriculturePresentation.Controllers
{
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            var values = _announcementService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(Announcement announcement)
        {
            announcement.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            announcement.Status = false;
           _announcementService.Insert(announcement);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAnnouncement(int id)
        {
            var value = _announcementService.GetById(id);
            _announcementService.Delete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var value = _announcementService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateAnnouncement(Announcement announcement)
        {
            _announcementService.Update(announcement);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToTrue(int id)
        {
            var value = _announcementService.GetById(id);
            if (value.Status == true)
            {
                _announcementService.IAnnouncementDalStatusToFalse(id);
                return RedirectToAction("Index");
                
            }
            else
            {
                _announcementService.IAnnouncementDalStatusToTrue(id);
                return RedirectToAction("Index");
            }
            
        }
        //public IActionResult ChangeStatusToFalse(int id)
        //{
        //    _announcementService.IAnnouncementDalStatusToFalse(id);
        //    return RedirectToAction("Index");
        //} <td><a href="/Announcement/ChangeStatusToFalse/@item.AnnouncementID" class="btn btn-outline-danger">Make Passive</a></td>


    }
}
