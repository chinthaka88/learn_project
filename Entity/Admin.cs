﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Admin
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public virtual User Users { get; set; }
    }
}
