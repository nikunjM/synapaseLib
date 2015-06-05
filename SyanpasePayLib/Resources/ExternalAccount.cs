using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyanpasePayLib.Resources
{
    public class ExternalAccount
    {
        public string expires_at { get; set; }
        public string expires_in { get; set; }
        public string oauth_consumer_key { get; set; }
        public string refresh_token { get; set; }
        public bool success { get; set; }
        public string user_id { get; set; }
        public string username { get; set; }
    }
}
