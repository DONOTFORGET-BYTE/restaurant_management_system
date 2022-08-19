using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace restaurant_management_system.Models
{
    public class order
    {
        public int order_id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int customer_id { get; set; }
        public int restaurant_id { get; set; }
    }
}