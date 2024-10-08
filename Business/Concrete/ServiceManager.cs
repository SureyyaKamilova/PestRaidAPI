﻿using Business.Abstract;
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
    public class ServiceManager : IService
    {
        private readonly IServiceDal _serviceDal;
        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public IResult AddService(Service service)
        {
            _serviceDal.Add(service);
            return new SuccessResult("Addedd");
        }

        public IResult DeleteService(Service service)
        {
            _serviceDal.Delete(service);
            return new SuccessResult("Addedd");
        }

        public IDataResult<Service> Get(int id)
        {
            var service = _serviceDal.Get(s => s.Id == id && s.IsDeleted == false);
            if (service != null)
            {
                return new SuccessDataResult<Service>(service);
            }
            else return new ErrorDataResult<Service>(service, "Not Founded!");
        }

        public IDataResult<List<Service>> GetAllServices()
        {
            var result = _serviceDal.GetAll(a => a.IsDeleted == false);
            if (result.Count > 0)
            {
                return new SuccessDataResult<List<Service>>(result);

            }
            else
            {
                return new ErrorDataResult<List<Service>>(result);
            }
        }

        public IResult UpdateService(Service service)
        {
            _serviceDal.Update(service);
            return new SuccessResult("Addedd");
        }
    }
}
