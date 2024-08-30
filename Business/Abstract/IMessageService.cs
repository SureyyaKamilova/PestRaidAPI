using Core.Helpers.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMessageService
    {
        IResult AddMessage(Message message);
        IResult DeleteMessage(Message message);
        IResult UpdateMessage(Message message);
        IDataResult<List<Message>> GetAllMessages();
        IDataResult<Message> Get(int id);
    }
}
