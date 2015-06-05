using SyanpasePayLib.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyanpasePayLib.Resources
{
    public class Orders
    {
        public string order_id { get; set; }
        public string times { get; set; }
        public string oauth_consumer_key { get; set; }
        public string amount { get; set; }
        public string facilitator_fee { get; set; }
        public string seller_id { get; set; }
        public string bank_id { get; set; }
        public int account_type { get; set; }
        public Bank bank { get; set; }
        public string date { get; set; }
        public object date_settled { get; set; }
        public int discount { get; set; }
        
        public double fee { get; set; }
        public int id { get; set; }
        public bool is_buyer { get; set; }
        public string note { get; set; }
        public string resource_uri { get; set; }
        public Seller seller { get; set; }
        public int status { get; set; }
        public string status_url { get; set; }
        public string supp_id { get; set; }
        public int ticket_number { get; set; }
        public int tip { get; set; }
        public int total { get; set; }
        
        public string nickname { get; set; }
        public bool balance_verified { get; set; }
        public Orders order { get; set; }
        public bool success { get; set; }


        public string recurring_time { get; set; }
    }
    public class Seller
    {
        public bool accept_gratuity { get; set; }
        public bool has_avatar { get; set; }
        public string seller_avatar { get; set; }
        public string seller_fullname { get; set; }
        public int seller_id { get; set; }
    }
    
         

}
