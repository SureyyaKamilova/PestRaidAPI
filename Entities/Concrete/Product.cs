﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ProductDetail {  get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; }
    }
}
