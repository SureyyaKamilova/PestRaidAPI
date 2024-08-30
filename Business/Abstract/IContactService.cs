using Core.Helpers.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IContactService
    {
        IResult AddContact(Contact contact);
        IResult DeleteContact(Contact contact);
        IResult UpdateContact(Contact contact);
        IDataResult<List<Contact>> GetAllContacts();
        IDataResult<Contact> Get(int id);
    }
}
