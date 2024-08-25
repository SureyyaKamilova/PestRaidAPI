using Core.Helpers.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IService
    {
        IResult AddService(Service service);
        IResult DeleteService(Service service);
        IResult UpdateService(Service service);
        IDataResult<List<Service>> GetAllServices();
        IDataResult<Service> Get(int id);
    }
}
