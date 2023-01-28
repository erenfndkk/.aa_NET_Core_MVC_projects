using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate.Repositort;
using DataAccessLayer.Contexts;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate.EntityFramework
{
    public class EfAnnouncementDal : GenericRepository<Announcement>, IAnnouncementDal
    {
        public void IAnnouncementDalStatusToFalse(int id)
        {
            using var context = new agricultureContext();
            Announcement p = context.Announcements.Find(id);
            p.Status = false;
            context.SaveChanges();
        }

        public void IAnnouncementDalStatusToTrue(int id)
        {
            using var context = new agricultureContext();
            Announcement p = context.Announcements.Find(id);
            p.Status = true;
            context.SaveChanges();
        }
    }
}
