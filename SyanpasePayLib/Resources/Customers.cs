using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This endpoint allows for the view all of the customers registered inside your sandbox
//So we can view list of customres using this function...
namespace SyanpasePayLib.Resources
{
    public class Customer
    {
        public bool accept_bank_payments { get; set; }
        public bool accept_gratuity { get; set; }
        public string email { get; set; }
        public string fullname { get; set; }
        public bool has_avatar { get; set; }
        public string phone_number { get; set; }
        public object resource_uri { get; set; }
        public string seller_details { get; set; }
        public int user_id { get; set; }
        public string username { get; set; }
        public int visit_count { get; set; }
        public string visit_message { get; set; }
    }

    public class CustomersObj
    {
        public List<Customer> customers { get; set; }
        public int obj_count { get; set; }
        public int page { get; set; }
        public int page_count { get; set; }
        public bool success { get; set; }
    }
}
