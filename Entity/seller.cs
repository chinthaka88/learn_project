using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Seller
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string email { get; set; }
        public string Country { get; set; }
        public string Rating { get; set; }
        public virtual User Users { get; set; }
    }
}
