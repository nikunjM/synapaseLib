using Newtonsoft.Json.Linq;
using SyanpasePayLib.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SyanpasePayLib.Resources;

namespace SyanpasePayLib.EndPoints
{
    public class BankEndpoint
    {
        //Link a Bank Account
        public string LinkBankAccount(SyanpasePayLib.Resources.Bank lBank)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = LinkBankAccountJson(lBank);
            string results = lhelp.APICalls(ljson, Settings.BANK_LINK_BANK_ACCOUNT_ENDPOINT, Settings.BANK_LINK_BANK_ACCOUNT_METHOD);
            return results;
        }
        /// <summary>
        /// there are three ways to do this verificatio, one is code based , other is qquestion based nad other is no validation
        /// for more info please visit http://api.synapsepay.com/v2.0/docs/mfa-bank-login
        /// </summary>
        /// <param name="lBank"></param>
        /// <param name="ljson"></param>
        /// <returns></returns>
        public string MFALogin(SyanpasePayLib.Resources.Bank lBank)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = MFAWithCodeLoginJson(lBank);
            string results = lhelp.APICalls(ljson, Settings.BANK_MFA_BANK_LOGIN_ENDPOINT, Settings.BANK_MFA_BANK_LOGIN_METHOD);
            return results;
        }

//        This endpoint allows a user to refresh bank data on the supplied bank account
        public string RefreshBankData(SyanpasePayLib.Resources.Bank lBank)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = RefreshBankDataJson(lBank);
            string results = lhelp.APICalls(ljson, Settings.BANK_REFRESH_BANK_LOGIN_ENDPOINT, Settings.BANK_REFRESH_BANK_LOGIN_METHOD);
            return results;
        }
        public string AddBank(SyanpasePayLib.Resources.Bank lBank)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = AddBankJson(lBank);
            string results = lhelp.APICalls(ljson, Settings.BANK_ADD_BANK_ENDPOINT, Settings.BANK_ADD_BANK_METHOD);
            return results;
        }

        public string RemoveBankAccount(SyanpasePayLib.Resources.Bank lBank)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = RemoveBankAccountJson(lBank);
            string results = lhelp.APICalls(ljson, Settings.BANK_REMOVE_BANK_ENDPOINT, Settings.BANK_REMOVE_BANK_METHOD);
            return results;
        }

        public string ViewLinkedBankAccounts(SyanpasePayLib.Resources.Bank lBank)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = ViewLinkedBankAccountJson(lBank);
            string results = lhelp.APICalls(ljson, Settings.BANK_VIEWING_BANK_ENDPOINT, Settings.BANK_VIEWING_BANK_METHOD);
            return results;
        }
        //check once u have proper credentials, everything else is checked.
        public string SetPrimaryAccount(SyanpasePayLib.Resources.Bank lBank)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = SettingPrimaryAccountJson(lBank);
            string results = lhelp.APICalls(ljson, Settings.BANK_SETTING_PRIMARY_BANK_ENDPOINT, Settings.BANK_SETTING_PRIMARY_BANK_METHOD);
            return results;
        }


        /// <summary>
        /// //below this part is all json objects
        /// </summary>
        /// <param name="lBank"></param>
        /// <returns></returns>
        public JObject LinkBankAccountJson(SyanpasePayLib.Resources.Bank lBank)
        {
            JObject pin = new JObject(
                new JProperty("username", lBank.username),
                //The username associated with the bank account you want to add to Synapse
                new JProperty("password", lBank.password),
              //bank password //this ahs to be encrypted and cant be stored in local system
                new JProperty("pin", lBank.pin),
                new JProperty("bank", lBank.bank_name),
                new JProperty("oauth_consumer_key", lBank.oauth_consumer_key)
        );
            return pin;
        }
        
        //this requires code, which is suppiled in email user recive....
        public JObject MFAWithCodeLoginJson(SyanpasePayLib.Resources.Bank lBank)
        {
            JObject pin = new JObject(
                new JProperty("access_token", lBank.access_token),
                new JProperty("mfa", lBank.mfa_code),
                new JProperty("bank", lBank.bank_name),
                new JProperty("oauth_consumer_key", lBank.oauth_consumer_key)
        );
            return pin;
        }
        public JObject RefreshBankDataJson(SyanpasePayLib.Resources.Bank lBank)
        {
            JObject pin = new JObject(
                new JProperty("id", lBank.id),//ID of the bank account, it recives during linking account.
                new JProperty("oauth_consumer_key", lBank.oauth_consumer_key)
        );
            return pin;
        }

        public JObject AddBankJson(SyanpasePayLib.Resources.Bank lBank)
        {
            JObject pin = new JObject(
                new JProperty("fullname", lBank.id),//The legal name associated with the bank account
                new JProperty("account_num", lBank.oauth_consumer_key),//The account number of the bank
                new JProperty("routing_num",lBank.routing_number_string),//The routing number of the bank
                new JProperty("nickname", lBank.nickname),//The nickname for the bank account
                new JProperty("account_class", lBank.account_class),//1 for personal, 2 for business account
                new JProperty("account_type", lBank.account_type),//1 for checking, 2 for savings account
                new JProperty("oauth_consumer_key", lBank.oauth_consumer_key)//The consumer key to include for authentication purposes
        );
            return pin;
        }
        public JObject RemoveBankAccountJson(SyanpasePayLib.Resources.Bank lBank)
        {
            JObject pin = new JObject(
                new JProperty("bank_id", lBank.id),//ID of the bank account, it recives during linking account.
                new JProperty("oauth_consumer_key", lBank.oauth_consumer_key)
        );
            return pin;
        }

        public JObject ViewLinkedBankAccountJson(SyanpasePayLib.Resources.Bank lBank)
        {
            JObject pin = new JObject(
                //new JProperty("id", lBank.id),//ID of the bank account, it recives during linking account.
                new JProperty("oauth_consumer_key", lBank.oauth_consumer_key)
        );
            return pin;
        }
        public JObject SettingPrimaryAccountJson(SyanpasePayLib.Resources.Bank lBank)
        {
            JObject pin = new JObject(
                new JProperty("bank_id", lBank.id),//ID of the bank account, it recives during linking account.
                new JProperty("oauth_consumer_key", lBank.oauth_consumer_key)
        );
            return pin;
        }
    }
}
