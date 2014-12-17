using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class OrderItem
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public int OrderID { get; set; }

        public int Qty { get; set; }

        public virtual Item Items { get; set; }
        public virtual Order Orders { get; set; }
    }
}
