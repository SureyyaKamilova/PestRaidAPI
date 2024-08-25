using Core.Helpers.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IClientsService
    {
        IResult AddClient(Client client);
        IResult DeleteClient(Client client);
        IResult UpdateClient(Client client);
        IDataResult<List<Client>> GetAllClients();
        IDataResult<Client> Get(int id);
    }
}
