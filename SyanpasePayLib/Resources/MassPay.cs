using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyanpasePayLib.Resources
{
    public class MassPay
    {
        public string amount { get; set; }
        public string trans_type { get; set; }
        public string card_id { get; set; }
        public string oauth_consumer_key { get; set; }
        public List<MassPay> mass_pays { get; set; }
        public int account_class { get; set; }
        public string account_number_string { get; set; }
        public int account_type { get; set; }
        public string date { get; set; }
        public int facilitator_fee { get; set; }
        public double fee { get; set; }
        public int id { get; set; }
        public string name_on_account { get; set; }
        public object resource_uri { get; set; }
        public string routing_number_string { get; set; }
        public int status { get; set; }
        public string status_url { get; set; }
        public string supp_id { get; set; }
        
        bool sucess { get; set; }
    }
}
