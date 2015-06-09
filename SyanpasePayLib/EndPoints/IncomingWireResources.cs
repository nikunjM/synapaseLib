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
    class IncomingWireResources
    {
        public string IncomingWireNotice(SyanpasePayLib.Resources.Wire lWire)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = IncomingWireNoticeJson(lWire);
            string results = lhelp.APICalls(ljson, Settings.INCOMING_WIRE_FUNDS_ENDPOINT, Settings.INCOMING_WIRE_FUNDS_METHOD);
            return results;
        }

        public string ViewIncomingWireNotice(SyanpasePayLib.Resources.Wire lWire)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = ViewIncomingWireNoticeJson(lWire);
            string results = lhelp.APICalls(ljson, Settings.VIEW_INCOMING_WIRE_FUNDS_ENDPOINT, Settings.VIEW_INCOMING_WIRE_FUNDS_METHOD);
            return results;
        }
        public string ViewIncomingWireNotice(SyanpasePayLib.Resources.Wire lWire, string byID)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = ViewIncomingWireNoticeByIdJson(lWire);
            string results = lhelp.APICalls(ljson, Settings.VIEW_INCOMING_WIRE_FUNDS_ENDPOINT, Settings.VIEW_INCOMING_WIRE_FUNDS_METHOD);
            return results;
        }
        //BELOW THIS POINT IS JSON OBJECTS..
        public JObject IncomingWireNoticeJson(SyanpasePayLib.Resources.Wire lWire)
        {
            JObject pin = new JObject(
                new JProperty("amount", lWire.amount),
                new JProperty("status_url", lWire.status_url),
                new JProperty("memo", lWire.memo),
                new JProperty("oauth_consumer_key", lWire.oauth_consumer_key)
                );
            return pin;

        }
        public JObject ViewIncomingWireNoticeJson(SyanpasePayLib.Resources.Wire lWire)
        {
            JObject pin = new JObject(
                new JProperty("oauth_consumer_key", lWire.oauth_consumer_key)
                );
            return pin;
        }
        public JObject ViewIncomingWireNoticeByIdJson(SyanpasePayLib.Resources.Wire lWire)
        {
            JObject pin = new JObject(
                new JProperty("id", lWire.id),
                new JProperty("oauth_consumer_key", lWire.oauth_consumer_key)
                );
            return pin;
        }

    }
}
