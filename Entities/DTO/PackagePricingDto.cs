using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class PackagePricingDto:IDto
    {
        
        public int PackageId {  get; set; }
        public string PackageName { get; set; }
        public string PackageVersion { get; set; }
        public string PackageType { get; set; }
        public int PricingId { get; set; }
        public string PricingName { get; set; }
        public string Description { get; set; }
        public decimal PricingPrice { get; set; }
    }
}
