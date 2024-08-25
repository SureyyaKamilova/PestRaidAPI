using Core.Helpers.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPartnerService
    {
        IResult AddPartner(Partner partner);
        IResult DeletePartner(Partner partner);
        IResult UpdatePartner(Partner partner);
        IDataResult<List<Partner>> GetAllPartners();
        IDataResult<Partner> Get(int id);
    }
}
