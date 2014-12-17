using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class WishList
    {
        public int ID { get; set; }
        public DateTime MyProperty { get; set; }
        public double Price { get; set; }

        public virtual Customer Customers { get; set; }
        public virtual ICollection<ItemWishList> ItemWishLists { get; set; }
    }
}
