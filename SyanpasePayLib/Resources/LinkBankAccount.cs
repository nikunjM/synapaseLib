using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * There are three ways to do this thing
 * question based 
 * Non Mfa Based 
 * Code based 
*/
namespace SyanpasePayLib.Resources
{
    class BankAccount
    {
        public string oauth_consumer_key { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string bank { get; set; }
        public int account_class { get; set; }
        public string account_number_string { get; set; }
        public int account_type { get; set; }
        public string address { get; set; }
        public string balance { get; set; }
        public string bank_name { get; set; }
        public string date { get; set; }
        public string email { get; set; }
        public int id { get; set; }
        public bool is_buyer_default { get; set; }
        public bool is_seller_default { get; set; }
        public bool mfa_verifed { get; set; }
        public string name_on_account { get; set; }
        public string nickname { get; set; }
        public string phone_number { get; set; }
        public object resource_uri { get; set; }
        public string routing_number_string { get; set; }
        public string supp_id { get; set; }
        public List<Bank> banks { get; set; }
        public bool is_mfa { get; set; }
        public bool success { get; set; }
    }

}

/*There are three ways to do this thing
question based 
Non Mfa Based 
Code based 
*/