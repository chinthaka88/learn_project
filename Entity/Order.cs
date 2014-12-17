using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int ItemID { get; set; }
        public DateTime Date { get; set; }
        public string Price { get; set; }
        public string CardNo { get; set; }
        public string ShippingAddress { get; set; }
        public virtual Customer Customers { get; set; }
        public virtual Item Items { get; set; }
    }
}
