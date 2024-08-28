using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfNewsDal : BaseEntityRepository<News, Context>, INewsDal
    {

        public List<News> GetListNewsWithCategory(int id)
        {
            using (var context = new Context())
            {
                return context.News.Include(x => x.Category)
                                     .Where(x => x.CategoryId == id).ToList();
            }
        }
    }
}
