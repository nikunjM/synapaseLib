using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyanpasePayLib.Resources
{
    public class Wire
    {
            public string oauth_consumer_key { get; set; }
            public string account_number { get; set; }
            public string routing_number { get; set; }
            public string amount { get; set; }
            public string account_number_string { get; set; }
            public string date { get; set; }
            public int fee { get; set; }
            public string id { get; set; }
            public string memo { get; set; }
            public string reference_id { get; set; }
            public object resource_uri { get; set; }
            public string routing_number_string { get; set; }
            public int status { get; set; }
            public string status_url { get; set; }
            public string reason { get; set; }
            public bool success { get; set; }
            public Wire wire { get; set; }
        }
    }


