using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ItemWishList
    {
        public int ID { get; set; }
        public int WishListID  { get; set; }
        public int ItemID { get; set; }

        public int Qty { get; set; }

        public virtual WishList WishLists { get; set; }
        public virtual Item Items { get; set; }

    }
}
