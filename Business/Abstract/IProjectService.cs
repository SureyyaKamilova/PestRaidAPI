using Core.Helpers.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProjectService
    {
        IResult AddProject(Project project);
        IResult DeleteProject(Project project);
        IResult UpdateProject(Project project);
        IDataResult<List<Project>> GetAllProjects();
        IDataResult<Project> Get(int id);
    }
}
