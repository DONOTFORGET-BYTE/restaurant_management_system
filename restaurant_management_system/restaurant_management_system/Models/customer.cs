using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace restaurant_management_system.Models
{
    public class customer
    {
        public int customer_id { get; set; }
        public string customer_email { get; set; }
        public int restaurant_id { get; set; }
        public string password { get; set; }
    }
}