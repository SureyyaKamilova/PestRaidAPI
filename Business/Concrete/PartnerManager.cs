using Business.Abstract;
using Core.Helpers.Results.Abstract;
using Core.Helpers.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PartnerManager : IPartnerService
    {
        private readonly IPartnerDal _partnerDal;
        public PartnerManager(IPartnerDal partnerDal)
        {
            _partnerDal = partnerDal;
        }

        public IResult AddPartner(Partner partner)
        {
            _partnerDal.Add(partner);
            return new SuccessResult("Addedd");
        }

        public void DeletePartner(Partner partner)
        {
            _partnerDal.Delete(partner);
        }

        public IDataResult<List<Partner>> GetAllPartners()
        {
            var partners = _partnerDal.GetAll(a => a.IsDeleted == false);
            if (partners.Count > 0)
            {
                return new SuccessDataResult<List<Partner>>(partners);

            }
            else
            {
                return new ErrorDataResult<List<Partner>>(partners);
            }

        }

        public void UpdatePartner(Partner partner)
        {
            _partnerDal.Update(partner);
        }
    }
}
