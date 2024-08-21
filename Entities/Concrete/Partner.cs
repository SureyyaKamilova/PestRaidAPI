using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Partner:BaseEntity
    {
        public string PartnerName { get; set; }
        public string ImageUrl {  get; set; }
        
    }
}
