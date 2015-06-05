using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyanpasePayLib.Resources
{
    public class Bank
    {
        public string access_token { get; set; }
        public string oauth_consumer_key { get; set; }
        public string pin { get; set; }
        public string username { get; set;}
        public string password { get; set; }
        public int account_class { get; set; }
        public string account_number_string { get; set; }
        public string account_type { get; set; }
        public string address { get; set; }
        public string balance { get; set; }
        public object bank_name { get; set; }
        public string date { get; set; }
        public string email { get; set; }
        public string id { get; set; }
        public bool is_buyer_default { get; set; }
        public bool is_seller_default { get; set; }
        public bool mfa_verifed { get; set; }
        public string mfa_code { get; set; }
        public string name_on_account { get; set; }
        public string nickname { get; set; }
        public string phone_number { get; set; }
        public object resource_uri { get; set; }
        public string routing_number_string { get; set; }
        public string supp_id { get; set; }
    }
    //View linked accounts will be done from here 
    //Set Primary 
    
}
