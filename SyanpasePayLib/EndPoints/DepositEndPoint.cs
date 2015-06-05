using System;
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
    public class DepositEndPoint
    {
        public string DepositFund(SyanpasePayLib.Resources.Deposit lDeposit)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = DepositFundJson(lDeposit);
            string results = lhelp.APICalls(ljson, Settings.DEPOSIT_FUNDS_TO_BANK_ENDPOINT, Settings.DEPOSIT_FUNDS_TO_BANK_METHOD);
            return results;
        }
        public string MicroDepositFund(SyanpasePayLib.Resources.Deposit lDeposit)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = MicroDepositFundJson(lDeposit);
            string results = lhelp.APICalls(ljson, Settings.MICRODEPOSIT_FUNDS_TO_BANK_ENDPOINT, Settings.MICRODEPOSIT_FUNDS_TO_BANK_METHOD);
            return results;
        }
        public string ViewDeposit(SyanpasePayLib.Resources.Deposit lDeposit,String byId)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = ViewSepcificDepositFundJson(lDeposit);
            string results = lhelp.APICalls(ljson, Settings.VIEW_DEPOSIT_FUNDS_ENDPOINT, Settings.VIEW_DEPOSIT_FUNDS_METHOD);
            return results;
        }
        public string ViewDeposit(SyanpasePayLib.Resources.Deposit lDeposit)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = ViewAllDepositFundJson(lDeposit);
            string results = lhelp.APICalls(ljson, Settings.VIEW_DEPOSIT_FUNDS_ENDPOINT, Settings.VIEW_DEPOSIT_FUNDS_METHOD);
            return results;
        }
        //BELOW THIS POINT IS JSON OBJECTS..
        public JObject DepositFundJson(SyanpasePayLib.Resources.Deposit lDeposit)
        {
            JObject pin = new JObject(
                new JProperty("amount", lDeposit.amount),
                new JProperty("bank_id", lDeposit.bank_id),
                new JProperty("status_url", lDeposit.status_url),
                new JProperty("supp_id", lDeposit.supp_id),
                new JProperty("oauth_consumer_key", lDeposit.oauth_consumer_key)
                );
            return pin;
        }
        public JObject MicroDepositFundJson(SyanpasePayLib.Resources.Deposit lDeposit)
        {
            JObject pin = new JObject(
                new JProperty("amount1", lDeposit.amount),
                new JProperty("amount2", lDeposit.amount1),
                new JProperty("bank_id", lDeposit.bank_id),
                new JProperty("status_url", lDeposit.status_url),
                new JProperty("oauth_consumer_key", lDeposit.oauth_consumer_key)
                );
            return pin;
        }
        public JObject ViewAllDepositFundJson(SyanpasePayLib.Resources.Deposit lDeposit)
        {
            JObject pin = new JObject(
                new JProperty("oauth_consumer_key", lDeposit.oauth_consumer_key)
                );
            return pin;
        }
        public JObject ViewSepcificDepositFundJson(SyanpasePayLib.Resources.Deposit lDeposit)
        {
            JObject pin = new JObject(
                new JProperty("id", lDeposit.id),
                new JProperty("supp_id", lDeposit.supp_id),
                new JProperty("oauth_consumer_key", lDeposit.oauth_consumer_key)
                );
            return pin;
        }
    }
}
