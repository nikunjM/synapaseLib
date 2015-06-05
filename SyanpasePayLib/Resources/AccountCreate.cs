using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyanpasePayLib.Resources
{
    public class Account
{
    public string email { get; set; }
    public string fullname { get; set; }
    public string ip_address { get; set; }
    public string phonenumber { get; set; }
    public string password { get; set; }
    public string client_id { get; set; }
    public string client_secret { get; set; }
    public string secret_note { get; set; }
    public string dp { get; set; }
//below this level all are the response we get from server
    public string expires_at{get;set;}
    public string access_token { get; set; }
    public string oauth_consumer_key { get; set; }
    public int expires_in { get; set; }
    public string reason { get; set; }
    public string refresh_token { get; set; }
    public bool success { get; set; }
    public string username { get; set; }
    public int user_id { get; set; }



    
}

}
