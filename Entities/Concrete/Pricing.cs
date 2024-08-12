using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Pricing:BaseEntity
    {
        public string PricingName {  get; set; }
        public string Description { get; set; } 
        public decimal PricingPrice {  get; set; }
        public bool Status { get; set; }
    }
}
