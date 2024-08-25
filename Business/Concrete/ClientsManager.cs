using Business.Abstract;
using Core.Helpers.Results.Abstract;
using Core.Helpers.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ClientsManager : IClientsService
    {
        private readonly IClientDal _clientDal;
        public ClientsManager(IClientDal clientDal)
        {
            _clientDal = clientDal;
        }

        public IResult AddClient(Client client)
        {
            _clientDal.Add(client);
            return new SuccessResult("Addedd Client!");
        }

        public IResult DeleteClient(Client client)
        {
            _clientDal.Delete(client);
            return new SuccessResult("Deleted Client!");
        }

        public IDataResult<Client> Get(int id)
        {
            var client = _clientDal.Get(c => c.Id == id && c.IsDeleted == false);
            if (client != null)
            {
                return new SuccessDataResult<Client>(client);
            }
            else return new ErrorDataResult<Client>(client, "Not Founded");
        }

        public IDataResult<List<Client>> GetAllClients()
        {
            var clients = _clientDal.GetAll(c => c.IsDeleted == false);
            if (clients.Count > 0)
            {
                return new SuccessDataResult<List<Client>>(clients);

            }
            else return new ErrorDataResult<List<Client>>(clients);
        }

        public IResult UpdateClient(Client client)
        {
            _clientDal.Update(client);
            return new SuccessResult("Updated Client!");
        }
    }
}
