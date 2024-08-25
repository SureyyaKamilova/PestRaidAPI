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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public IResult AddAbout(About about)
        {
            
            _aboutDal.Add(about);
            return new SuccessResult("Addedd");

        }

        public IResult DeleteAbout(About about)
        {
            _aboutDal.Delete(about);
            return new SuccessResult("Deleted");
        }

        public IDataResult<About> Get(int id)
        {
            var about = _aboutDal.Get(a => a.Id == id && a.IsDeleted == false);
            if (about != null)
            {
                return new SuccessDataResult<About>(about);
            }
            else return new ErrorDataResult<About>(about, "Not Founded!");
        }

        public IDataResult<List<About>> GetAllAbouts()
        {
            var abouts = _aboutDal.GetAll(a => a.IsDeleted == false);
            if (abouts.Count > 0)
            {
                return new SuccessDataResult<List<About>>(abouts);

            }
            else return new ErrorDataResult<List<About>>(abouts);


        }
        public IResult UpdateAbout(About about)
        {
            _aboutDal.Update(about);
            return new SuccessResult("Updated");
        }
    }
}
