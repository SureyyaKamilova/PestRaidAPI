using Core.Helpers.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface INewsService
    {
        IResult AddNews(News news);
        IResult DeleteNews(News news);
        IResult UpdateNews(News news);
        IDataResult<List<News>> GetAllNews();
        IDataResult<News> Get(int id);
        List<News> GetListNewsWithCategory(int id);
    }
}
