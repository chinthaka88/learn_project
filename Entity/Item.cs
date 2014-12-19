using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public double Currency { get; set; }
        public string Image { get; set; }
        public int Qty { get; set; }
        public string Description { get; set; }
        public string Condition { get; set; }
        public string Shipping { get; set; }
        public double Discount { get; set; }
        public double ShippedWithIn { get; set; }

        public virtual Category Categorys { get; set; }
        public virtual ICollection<ItemWishList> ItemWishLists { get; set; }
        public virtual Seller sellers { get; set; }
        public virtual ICollection<ShippingCompanyItem> ShippingItems { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<ViewCount> ViewCounts { get; set; }
        
    }
}
