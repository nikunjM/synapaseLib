using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyanpasePayLib.Resources
{
    class IncomingWireNotice
    {
        public string oauth_consumer_key { get; set; }
        public string date { get; set; }
        public int fee { get; set; }
        public int id { get; set; }
        public string memo { get; set; }
        public string reference_id { get; set; }
        public object resource_uri { get; set; }
        public int status { get; set; }
        public string status_url { get; set; }
        public string reason { get; set; }
        public bool success { get; set; }
        public Wire wire { get; set; }
    }
}
