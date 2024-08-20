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
    public class ServiceAboutManager : IServiceAbout
    {
        private readonly IServiceAboutDal _serviceAboutDal;
        public ServiceAboutManager(IServiceAboutDal serviceAboutDal)
        {
            _serviceAboutDal = serviceAboutDal;
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
    }
}
