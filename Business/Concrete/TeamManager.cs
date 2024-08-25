using Business.Abstract;
using Core.Helpers.Results.Abstract;
using Core.Helpers.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TeamManager : ITeamService
    {
        private readonly ITeamDal _teamDal;
        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }
        public IResult AddTeam(Team team)
        {
            _teamDal.Add(team);
            return new SuccessResult("Addedd");
        }

        public IResult DeleteTeam(Team team)
        {
            _teamDal.Delete(team);
            return new SuccessResult("Deleted");
        }

        public IDataResult<Team> Get(int id)
        {
            var team = _teamDal.Get(t => t.Id == id && t.IsDeleted == false);
            if(team != null)
            {
                return new SuccessDataResult<Team>(team);
            }
            else
            {
                return new ErrorDataResult<Team>(team, "Not found!");
            }
        }

        public IDataResult<List<Team>> GetAllTeams()
        {
            var teams = _teamDal.GetAll(t=>t.IsDeleted==false);
            if (teams.Count > 0)
            {
                return new SuccessDataResult<List<Team>>(teams);
            }
            else
            {
                return new ErrorDataResult<List<Team>>("Error");
            }
        }

        public IResult UpdateTeam(Team team)
        {
            _teamDal.Update(team);
            return new SuccessResult("Updated");
        }
    }
}
