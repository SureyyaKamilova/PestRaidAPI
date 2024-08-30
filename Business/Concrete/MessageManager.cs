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
    public class MessageManager : IMessageService
    {
        private readonly IMessageDal _messagedal;
        public MessageManager(IMessageDal messagedal)
        {
            _messagedal = messagedal;
        }

        public IResult AddMessage(Message message)
        {
            _messagedal.Add(message);
            return new SuccessResult("Added Message");
        }

        public IResult DeleteMessage(Message message)
        {
            _messagedal.Delete(message);
            return new SuccessResult("Deleted Message");
        }

        public IDataResult<Message> Get(int id)
        {
            var message = _messagedal.Get(a => a.Id == id && a.IsDeleted == false);
            if (message != null)
            {
                return new SuccessDataResult<Message>(message);
            }
            else return new ErrorDataResult<Message>(message, "Not Founded!");
        }

        public IDataResult<List<Message>> GetAllMessages()
        {
            var messages = _messagedal.GetAll(a => a.IsDeleted == false);
            if (messages.Count > 0)
            {
                return new SuccessDataResult<List<Message>>(messages);

            }
            else return new ErrorDataResult<List<Message>>(messages);

        }

        public IResult UpdateMessage(Message message)
        {
            _messagedal.Update(message);
            return new SuccessResult("Update Message");
        }
    }
}
