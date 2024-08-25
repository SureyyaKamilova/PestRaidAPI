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

        public IResult DeletePartner(Partner partner)
        {
            _partnerDal.Delete(partner);
            return new SuccessResult("Deleted");
        }

        public IDataResult<Partner> Get(int id)
        {
            var partner = _partnerDal.Get(a => a.Id == id && a.IsDeleted == false);
            if (partner != null)
            {
                return new SuccessDataResult<Partner>(partner);
            }
            else return new ErrorDataResult<Partner>(partner, "Not Founded!");
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

        public IResult UpdatePartner(Partner partner)
        {
            _partnerDal.Update(partner);
            return new SuccessResult("Updated");
        }
    }
}
