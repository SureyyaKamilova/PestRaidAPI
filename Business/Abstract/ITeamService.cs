using Core.Helpers.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITeamService
    {
        IResult AddTeam(Team team);
        IResult DeleteTeam(Team team);
        IResult UpdateTeam(Team team);
        IDataResult<List<Team>> GetAllTeams();
        IDataResult<Team> Get(int id);
    }
}
