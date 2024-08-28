using Business.Abstract;
using Core.Helpers.Results.Abstract;
using Core.Helpers.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class NewsManager : INewsService
    {
        private readonly INewsDal _newsDal;
        public NewsManager(INewsDal newsDal)
        {
            _newsDal = newsDal;
        }

        public IResult AddNews(News news)
        {
            _newsDal.Add(news);
            return new SuccessResult("Addedd News");
        }

        public IResult DeleteNews(News news)
        {
            _newsDal.Delete(news);
            return new SuccessResult("Deleted News");
        }

        public IDataResult<News> Get(int id)
        {
            var news = _newsDal.Get(a => a.Id == id && a.IsDeleted == false);
            if (news != null)
            {
                return new SuccessDataResult<News>(news);
            }
            else return new ErrorDataResult<News>(news, "Not Founded!");
        }

        public IDataResult<List<News>> GetAllNews()
        {
            var news = _newsDal.GetAll(a => a.IsDeleted == false);
            if (news.Count > 0)
            {
                return new SuccessDataResult<List<News>>(news);

            }
            else return new ErrorDataResult<List<News>>(news);
        }

        public List<News> GetListNewsWithCategory(int id)
        {
            return _newsDal.GetAll(x => x.Id == id);
        }

        public IResult UpdateNews(News news)
        {
            _newsDal.Update(news);
            return new SuccessResult("Updated News");
        }
    }
}
