using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace SyanpasePayLib.Resources
{
    public class MassPay
    {
        public string legal_name { get; set; }
        public string account_number { get; set; }
        public string routing_number { get; set; }
        public string amount { get; set; }
        public string trans_type { get; set; }
        public string account_class { get; set; }
        public string account_type { get; set; }
        public string status_url { get; set; }
        public string supp_id { get; set; }
        public UserInfo user { get; set; }
    }

    public class MassPayList
    {
        public string oauth_consumer_key { get; set; }
        public string bank_id { get; set; }
        public string facilitator_fee { get; set; }
        public IList<MassPay> mass_pays { get; set; }

    }


    public class UserInfo
    {
        public string email{get;set;}
        public string phone_number { get; set; }
        public string ip_address { get; set; }
        public string dob { get; set; }
        public string risk_score { get; set; }
        public string ssn { get; set; }
    }


}
