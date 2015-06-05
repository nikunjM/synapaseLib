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
    public class OrderEndPoint
    {
        public string CreateOrder(SyanpasePayLib.Resources.Orders lOrder)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = CreateOrderJson(lOrder);
            string results = lhelp.APICalls(ljson, Settings.ORDER_CREATE_ORDER_ENDPOINT, Settings.ORDER_CREATE_ORDER_METHOD);
            return results;
        }
        public string PollOrders(SyanpasePayLib.Resources.Orders lOrder)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = PollOrderJson(lOrder);
            string results = lhelp.APICalls(ljson, Settings.ORDER_ORDER_POLL_ENDPOINT, Settings.ORDER_ORDER_POLL_METHOD);
            return results;
        }
        public string UpdateOrders(SyanpasePayLib.Resources.Orders lOrder)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = UpdateOrderJson(lOrder);
            string results = lhelp.APICalls(ljson, Settings.ORDER_UPDATE_ENDPOINT, Settings.ORDER_UPDATE_METHOD);
            return results;
        }
        public string VoidOrders(SyanpasePayLib.Resources.Orders lOrder)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = VoidOrderJson(lOrder);
            string results = lhelp.APICalls(ljson, Settings.ORDER_VOID_ENDPOINT, Settings.ORDER_VOID_METHOD);
            return results;
        }
        public string ViewRecentOrders(SyanpasePayLib.Resources.Orders lOrder)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = ViewRecentOrderOrderJson(lOrder);
            string results = lhelp.APICalls(ljson, Settings.ORDER_VIEW_RECENT_ENDPOINT, Settings.ORDER_VIEW_RECENT_METHOD);
            return results;
        }
       //BELOW THIS POINT IS JSON OBJECTS..
        public JObject CreateOrderJson(SyanpasePayLib.Resources.Orders lOrders)
        {
            JObject pin = new JObject(
                new JProperty("amount", lOrders.amount),
                new JProperty("seller_id",lOrders.seller_id),
                new JProperty("bank_id", lOrders.bank_id),
                new JProperty("note", lOrders.note),
                new JProperty("status_url", lOrders.status_url),
                new JProperty("facilitator_fee", lOrders.facilitator_fee),
                new JProperty("recurring_time", lOrders.recurring_time),
                new JProperty("times", lOrders.times),
                new JProperty("supp_id", lOrders.supp_id),
                new JProperty("oauth_consumer_key", lOrders.oauth_consumer_key)

        );
            return pin;
        }
        public JObject PollOrderJson(SyanpasePayLib.Resources.Orders lOrders)
        {
            JObject pin = new JObject(
                new JProperty("order_id", lOrders.order_id)
        );
            return pin;
        }
        public JObject UpdateOrderJson(SyanpasePayLib.Resources.Orders lOrders)
        {
            JObject pin = new JObject(
                new JProperty("order_id:", lOrders.amount),
                new JProperty("supp_id", lOrders.seller_id),
                new JProperty("status", lOrders.bank_id),
                new JProperty("oauth_consumer_key", lOrders.oauth_consumer_key)
         );
            return pin;
        }
        public JObject VoidOrderJson(SyanpasePayLib.Resources.Orders lOrders)
        {
            JObject pin = new JObject(
                new JProperty("order_id:", lOrders.amount),
                new JProperty("supp_id", lOrders.seller_id),
                new JProperty("oauth_consumer_key", lOrders.oauth_consumer_key)
         );
            return pin;
        }
        public JObject ViewRecentOrderOrderJson(SyanpasePayLib.Resources.Orders lOrders)
        {
            JObject pin = new JObject(
                new JProperty("order_id:", lOrders.amount),
                new JProperty("supp_id", lOrders.seller_id),
                new JProperty("oauth_consumer_key", lOrders.oauth_consumer_key)
         );
            return pin;
        }

    }
}
