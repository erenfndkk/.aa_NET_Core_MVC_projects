using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class TeamManager:ITeamService
    {
        private readonly ITeamDal _teamdal;

        public TeamManager(ITeamDal teamdal)
        {
            _teamdal = teamdal;
        }

        public void Delete(Team t)
        {
            _teamdal.Delete(t);
        }

        public Team GetById(int id)
        {
            return _teamdal.GetById(id);
        }

        public List<Team> GetListAll()
        {
            return _teamdal.GetListAll();
        }

        public void Insert(Team t)
        {
            _teamdal.Insert(t);
        }

        public void Update(Team t)
        {
            _teamdal.Update(t);
        }
    }
}
