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
    public class WireEndPoints
    {
        public string CreateWire(SyanpasePayLib.Resources.Wire lDeposit)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = CreateWireJson(lDeposit);
            string results = lhelp.APICalls(ljson, Settings.WIRE_DEPOSIT_FUNDS_ENDPOINT, Settings.WIRE_DEPOSIT_FUNDS_METHOD);
            return results;
        }
        public string ViewWire(SyanpasePayLib.Resources.Wire lDeposit)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = ViewAllWireJson(lDeposit);
            string results = lhelp.APICalls(ljson, Settings.WIRE_VIEW_FUNDS_ENDPOINT, Settings.WIRE_VIEW_FUNDS_METHOD);
            return results;
        }
        public string ViewWire(SyanpasePayLib.Resources.Wire lDeposit, string byId)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = ViewSpecificWireJson(lDeposit);
            string results = lhelp.APICalls(ljson, Settings.WIRE_VIEW_FUNDS_ENDPOINT, Settings.WIRE_VIEW_FUNDS_METHOD);
            return results;
        }

        //Object 
        public JObject CreateWireJson(SyanpasePayLib.Resources.Wire lWire)
        {
            JObject pin = new JObject(
                new JProperty("amount", lWire.amount),
                new JProperty("account_number", lWire.account_number),
                new JProperty("routing_number", lWire.routing_number),
                new JProperty("memo", lWire.memo),
                new JProperty("oauth_consumer_key", lWire.oauth_consumer_key)
                );
            return pin;
        }
        public JObject ViewSpecificWireJson(SyanpasePayLib.Resources.Wire lWire)
        {
            JObject pin = new JObject(
                new JProperty("id", lWire.id),
                new JProperty("oauth_consumer_key", lWire.oauth_consumer_key)
                );
            return pin;
        }

        public JObject ViewAllWireJson(SyanpasePayLib.Resources.Wire lWire)
        {
            JObject pin = new JObject(
                new JProperty("oauth_consumer_key", lWire.oauth_consumer_key)
                );
            return pin;
        }

    }
}
