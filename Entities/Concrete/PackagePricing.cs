using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class PackagePricing:BaseEntity
    {
        public int PricingId { get; set; }
        public int PackageId { get; set; }
        public decimal Price { get; set; }
    }
}
