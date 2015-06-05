using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyanpasePayLib.Resources
{
    class Cards
    {
        public string oauth_consumer_key { get; set; }
        public string legal_name { get; set; }
        public string account_number { get; set; }
        public string routing_number { get; set; }
        public string account_class { get; set; }
        public string account_type { get; set; }
    
        public string account_number_string { get; set; }

        public string bank_name { get; set; }
        public int id { get; set; }
        public string name_on_account { get; set; }
        public object resource_uri { get; set; }
        public string routing_number_string { get; set; }
        public string supp_id { get; set; }
        public Cards card { get; set; }
        public bool success { get; set; }
    }
}
