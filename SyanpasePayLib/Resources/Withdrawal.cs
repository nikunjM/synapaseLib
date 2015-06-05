using SyanpasePayLib.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyanpasePayLib.Resources
{
    class Withdrawal
       {
        public string supp_id { get; set; }
        public string oauth_consumer_key { get; set; }
        public string bank_id { get; set; }
        public string amount { get; set; }
        public double balance { get; set; }
        public bool is_mfa { get; set; }
        public string reason { get; set; }
        public bool success { get; set; }
        public Withdrawal withdrawal { get; set; }
        public Bank bank { get; set; }
        public string date_created { get; set; }
        public int fee { get; set; }
        public int id { get; set; }
        public int instant_credit { get; set; }
        public object resource_uri { get; set; }
        public int status { get; set; }
        public string status_url { get; set; }
        public int user_id { get; set; }
        public string name_on_account { get; set; }
        public string nickname { get; set; }
    }
}
