using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public int AvailableItem { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
