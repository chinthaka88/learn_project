using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ViewCount
    {
        public int? ID { get; set; }
        public DateTime Date { get; set; }
        public int count { get; set; }
        public virtual Item Items { get; set; }
    }
}
