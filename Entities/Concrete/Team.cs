using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities.Concrete
{
    public class Team : BaseEntity
    {
        public string FullName { get; set; }
        public string About { get; set; }
        public string ImageUrl { get; set; }
        public string Role {  get; set; }
    }
}
