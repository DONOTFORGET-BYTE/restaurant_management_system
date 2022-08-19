using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace restaurant_management_system.Models
{
    public class reservation
    {
        public int reservation_id { get; set; }
        public DateTime startdatetime { get; set; }
        public string type_of_table { get; set; }
        public string purpose { get; set; }
        public string description { get; set; }
        public int customer_id { get; set; }
        public string reservation_status { get; set; }

    }
}