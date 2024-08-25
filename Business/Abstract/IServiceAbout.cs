using Core.Helpers.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IServiceAbout
    {
        IResult AddServiceAbout(ServiceAbout serviceAbout);
        IResult DeleteServiceAbout(ServiceAbout serviceAbout);
        IResult UpdateServiceAbout(ServiceAbout serviceAbout);
        IDataResult<ServiceAbout> Get(int id);
        IDataResult<List<ServiceAbout>> GetAllServiceAbouts();
    }
}
