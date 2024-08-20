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

        public void DeleteAbout(About about)
        {
            _aboutDal.Delete(about);
        }


        public IDataResult<List<About>> GetAllAbouts()
        {
            var abouts = _aboutDal.GetAll(a=>a.IsDeleted == false);
            if (abouts.Count > 0)
            {
                return new SuccessDataResult<List<About>>(abouts);

            }
            else
            {
                return new ErrorDataResult<List<About>>(abouts);
            }

        }

        public void UpdateAbout(About about)
        {
            _aboutDal.Update(about);
        }
    }
}
