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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public IResult AddContact(Contact contact)
        {
            _contactDal.Add(contact);
            return new SuccessResult("Addedd");
        }

        public IResult DeleteContact(Contact contact)
        {
            _contactDal.Delete(contact);
            return new SuccessResult("Deleted");
        }

        public IDataResult<Contact> Get(int id)
        {
            var contact = _contactDal.Get(a => a.Id == id && a.IsDeleted == false);
            if (contact != null)
            {
                return new SuccessDataResult<Contact>(contact);
            }
            else return new ErrorDataResult<Contact>(contact, "Not Founded!");
        }

        public IDataResult<List<Contact>> GetAllContacts()
        {
            var contacts = _contactDal.GetAll(a => a.IsDeleted == false);
            if (contacts.Count > 0)
            {
                return new SuccessDataResult<List<Contact>>(contacts);

            }
            else return new ErrorDataResult<List<Contact>>(contacts);
        }

        public IResult UpdateContact(Contact contact)
        {
            _contactDal.Update(contact);
            return new SuccessResult("Updated");
        }
    }
}
