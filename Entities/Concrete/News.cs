using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class News: BaseEntity
    {
        public string NewsTitle { get; set; }
        public string NewsContent { get; set; }
        public string BNewsImage { get; set; }
        public DateTime NewsCreateDate { get; set; }
        public bool NewsStatus { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
