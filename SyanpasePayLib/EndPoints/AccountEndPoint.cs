using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SyanpasePayLib.Resources;
using System.Web;
using System.Net;
using System.IO;
using SyanpasePayLib;
using SyanpasePayLib.Helpers;

namespace SyanpasePayLib.EndPoints
{
    public class AccountEndPoint
    {
        //This endpoint allows for the creation of a new user.
        //returns json that can be added to databse 
        //add result to extreenal table.

        //insetd of account if i added extrnal account, that will add into database

        // there is no need to pass Account class to any of the classes, i just added this for 
        //testing purpose and to chekc and return type, pleaser remove it if not wanted.
        public Account CreatAccount(Account lacc)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = CreatUserJson(lacc);
            string results = lhelp.APICalls(ljson, Settings.ACCOUNT_CREATE_ENDPOINT, Settings.ACCOUNT_CREATE_METHOD);
            
            JToken token = JObject.Parse(results);
           // Account lacc = new Account();
            lacc.expires_at = (string)token.SelectToken("expires_at");
            lacc.expires_in = (int)token.SelectToken("expires_in");
            lacc.oauth_consumer_key = (string)token.SelectToken("oauth_consumer_key");
            lacc.refresh_token=(string)token.SelectToken("refresh_token");
            lacc.success=(bool)token.SelectToken("success");
            lacc.user_id=(int)token.SelectToken("user_id");
            lacc.username = (string)token.SelectToken("username");

            return lacc;
        }
        public string Login(Account laccount) 
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = LogInUserJson(laccount);
            string results = lhelp.APICalls(ljson, Settings.ACCOUNT_LOGIN_ENDPOINT, Settings.ACCOUNT_LOGIN_METHOD);
            return results;
        }

        public string RefreshAccess(Account lacc) 
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = RefreshAccessJson(lacc);
            string results = lhelp.APICalls(ljson, Settings.ACCOUNT_REFRESH_ACCESS_ENDPOINT, Settings.ACCOUNT_REFRESH_ACCESS_METHOD);
            return results;
        }
        public string EdituserInfo(Account lacc)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = EditUserInfoJson(lacc); 
            string results = lhelp.APICalls(ljson, Settings.ACCOUNT_EDIT_INFO_ENDPOINT, Settings.ACCOUNT_EDIT_INFO_METHOD);
            return results;
        }

        public string ViewUserInfo(Account lacc)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = ViewUserInfoJson(lacc);
            string results = lhelp.APICalls(ljson, Settings.ACCOUNT_VIEW_INFO_ENDPOINT, Settings.ACCOUNT_VIEW_INFO_METHOD);
            return results;
        }

        
        public JObject CreatUserJson(Account lacc)
        {
            JObject pin = new JObject(
                new JProperty("email", lacc.email),
                new JProperty("fullname", lacc.fullname),
                new JProperty("phonenumber", lacc.phonenumber),
                new JProperty("ip_address", lacc.ip_address),
                new JProperty("password", lacc.password),
                new JProperty("client_id", Settings.Globals.CLIENT_ID),
                new JProperty("client_secret", Settings.Globals.CLIENT_SECRET)
        );
            return pin;
        }
        public JObject LogInUserJson(Account lacc)
        {
            JObject pin = new JObject(
                new JProperty("username", lacc.username),
                new JProperty("password", lacc.password),
                new JProperty("client_id", Settings.Globals.CLIENT_ID),
                new JProperty("client_secret", Settings.Globals.CLIENT_SECRET)
        );
            return pin;
        }

        public JObject RefreshAccessJson(Account lacc)
        {
            JObject pin = new JObject(
                new JProperty("refresh_token", lacc.refresh_token),
                new JProperty("client_id", Settings.Globals.CLIENT_ID),
                new JProperty("client_secret", Settings.Globals.CLIENT_SECRET)
        );
            return pin;
        }

        public JObject ViewUserInfoJson(Account lacc)
        {
            JObject pin = new JObject(
                new JProperty("oauth_consumer_key", lacc.oauth_consumer_key),
                new JProperty("client_id", Settings.Globals.CLIENT_ID),
                new JProperty("client_secret", Settings.Globals.CLIENT_SECRET)
        );
            return pin;
        }

        public JObject EditUserInfoJson(Account lacc)
        {
            JObject pin = new JObject(
                new JProperty("fullname", lacc.fullname),
                new JProperty("new_password", lacc.password),
                new JProperty("secret_note", lacc.secret_note),
                new JProperty("dp", lacc.dp),
                new JProperty("oauth_consumer_key", lacc.oauth_consumer_key),
                new JProperty("client_id", Settings.Globals.CLIENT_ID),
                new JProperty("client_secret", Settings.Globals.CLIENT_SECRET)
        );
            return pin;
        }
    }
}
