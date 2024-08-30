using Business.Abstract;
using Core.Helpers.Results.Abstract;
using Core.Helpers.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProjectManager : IProjectService
    {
        private readonly IProjectDal _projectDal;
        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public IResult AddProject(Project project)
        {
            _projectDal.Add(project);
            return new SuccessResult("Added Project!");
        }

        public IResult DeleteProject(Project project)
        {
            _projectDal.Delete(project);
            return new SuccessResult("Deleted Project!");
        }

        public IDataResult<Project> Get(int id)
        {
            var project = _projectDal.Get(a => a.Id == id && a.IsDeleted == false);
            if (project != null)
            {
                return new SuccessDataResult<Project>(project);
            }
            else return new ErrorDataResult<Project>(project, "Not Founded!");
        }

        public IDataResult<List<Project>> GetAllProjects()
        {
            var projects = _projectDal.GetAll(a => a.IsDeleted == false);
            if (projects.Count > 0)
            {
                return new SuccessDataResult<List<Project>>(projects);

            }
            else return new ErrorDataResult<List<Project>>(projects);
        }

        public IResult UpdateProject(Project project)
        {
            _projectDal.Update(project);
            return new SuccessResult("Updated Project!");
        }
    }
}
