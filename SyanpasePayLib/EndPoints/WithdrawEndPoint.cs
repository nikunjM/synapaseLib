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
    class WithdrawEndPoint
    {
        //This endpoint adds the specified amount into the user’s Synapse Account from their bank account.
        public string AddFundsToAccount(SyanpasePayLib.Resources.Withdrawal lWithdrawal)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = AddFundsToAccountJson(lWithdrawal);
            string results = lhelp.APICalls(ljson, Settings.WIRE_DEPOSIT_FUNDS_ENDPOINT, Settings.WIRE_DEPOSIT_FUNDS_METHOD);
            return results;
        }
        public string ViewWithdrawals(SyanpasePayLib.Resources.Withdrawal lWithdrawal)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = ViewFundsToAccountJson(lWithdrawal);
            string results = lhelp.APICalls(ljson, Settings.VIEW_WITHDRAW_FUNDS_ENDPOINT, Settings.VIEW_WITHDRAW_FUNDS_METHOD);
            return results;
        }
        public string ViewWithdrawals(SyanpasePayLib.Resources.Withdrawal lWithdrawal,string byId)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = ViewFundsToAccountByIDJson(lWithdrawal);
            string results = lhelp.APICalls(ljson, Settings.VIEW_WITHDRAW_FUNDS_ENDPOINT, Settings.VIEW_WITHDRAW_FUNDS_METHOD);
            return results;
        }

        //BELOW THIS POINT IS JSON OBJECTS..
        public JObject AddFundsToAccountJson(SyanpasePayLib.Resources.Withdrawal lWithdrawal)
        {
            JObject pin = new JObject(
                new JProperty("amount", lWithdrawal.amount),
                new JProperty("bank_id", lWithdrawal.bank_id),
                new JProperty("status_url", lWithdrawal.status_url),
                new JProperty("supp_id", lWithdrawal.supp_id),
                new JProperty("oauth_consumer_key", lWithdrawal.oauth_consumer_key)
                );
            return pin;
        }
        public JObject ViewFundsToAccountByIDJson(SyanpasePayLib.Resources.Withdrawal lWithdrawal)
        {
            JObject pin = new JObject(
                new JProperty("id", lWithdrawal.id),
                new JProperty("oauth_consumer_key", lWithdrawal.oauth_consumer_key)
                );
            return pin;
        }
        public JObject ViewFundsToAccountJson(SyanpasePayLib.Resources.Withdrawal lWithdrawal)
        {
            JObject pin = new JObject(
                new JProperty("oauth_consumer_key", lWithdrawal.oauth_consumer_key)
                );
            return pin;
        }
    }
}
