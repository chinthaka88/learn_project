﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class ShippingCompany
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ShippingCompanyItem> ShippingItems { get; set; }
    }
}
