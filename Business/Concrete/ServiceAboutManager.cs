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
    public class ServiceAboutManager : IServiceAbout
    {
        private readonly IServiceAboutDal _serviceAboutDal;
        public ServiceAboutManager(IServiceAboutDal serviceAboutDal)
        {
            _serviceAboutDal = serviceAboutDal;
        }

        public IResult AddServiceAbout(ServiceAbout serviceAbout)
        {
            _serviceAboutDal.Add(serviceAbout);
            return new SuccessResult("Addedd");
        }

        public IResult DeleteServiceAbout(ServiceAbout serviceAbout)
        {
            _serviceAboutDal.Delete(serviceAbout);
            return new SuccessResult("Deleted");
        }

        public IDataResult<ServiceAbout> Get(int id)
        {
            var serviceAbout = _serviceAboutDal.Get(a => a.Id == id && a.IsDeleted == false);
            if (serviceAbout != null)
            {
                return new SuccessDataResult<ServiceAbout>(serviceAbout);
            }
            else return new ErrorDataResult<ServiceAbout>(serviceAbout, "Not Founded!");
        }

        public IDataResult<List<ServiceAbout>> GetAllServiceAbouts()
        {
            var result = _serviceAboutDal.GetAll(a => a.IsDeleted == false);
            if (result.Count > 0)
            {
                return new SuccessDataResult<List<ServiceAbout>>(result);

            }
            else
            {
                return new ErrorDataResult<List<ServiceAbout>>(result);
            }
        }

        public IResult UpdateServiceAbout(ServiceAbout serviceAbout)
        {
            _serviceAboutDal.Update(serviceAbout);
            return new SuccessResult("Updated!");
        }
    }
}
