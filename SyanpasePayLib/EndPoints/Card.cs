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
    class Card
    {
        public string AddCard(SyanpasePayLib.Resources.Cards lCards)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = AddCardJson(lCards);
            string results = lhelp.APICalls(ljson, Settings.ADD_CARDS_ENDPOINT, Settings.ADD_CARDS_METHOD);
            return results;
        }
        public string EditCard(SyanpasePayLib.Resources.Cards lCards)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = EditCardJson(lCards);
            string results = lhelp.APICalls(ljson, Settings.EDIT_CARDS_ENDPOINT, Settings.EDIT_CARDS_METHOD);
            return results;
        }
        public string ShowCard(SyanpasePayLib.Resources.Cards lCards)
        {
            RestHelper lhelp = new RestHelper();
            JObject ljson = ShowCardJson(lCards);
            string results = lhelp.APICalls(ljson, Settings.SHOW_CARDS_ENDPOINT, Settings.SHOW_CARDS_METHOD);
            return results;
        }
        //below this point all are json objects
        public JObject AddCardJson(SyanpasePayLib.Resources.Cards lCards)
        {
            JObject pin = new JObject(
                new JProperty("legal_name", lCards.legal_name),//leagal name on bank account
                new JProperty("supp_id", lCards.supp_id),//id od the card u wish to add
                new JProperty("account_number", lCards.account_number),
                new JProperty("routing_number", lCards.routing_number_string),
                new JProperty("account_class", lCards.account_class),//1 for personal, 2 for business account
                new JProperty("account_type", lCards.account_type),//1 for checking, 2 for savings account
                new JProperty("oauth_consumer_key", lCards.oauth_consumer_key)
                );
            return pin;
        }
        public JObject EditCardJson(SyanpasePayLib.Resources.Cards lCards)
        {
            JObject pin = new JObject(
                new JProperty("id", lCards.legal_name),
                new JProperty("supp_id", lCards.supp_id),//id od the card u wish to add
                new JProperty("legal_name", lCards.legal_name),//leagal name on bank account
                new JProperty("account_number", lCards.account_number),
                new JProperty("routing_number", lCards.routing_number_string),
                new JProperty("account_class", lCards.account_class),//1 for personal, 2 for business account
                new JProperty("account_type", lCards.account_type),//1 for checking, 2 for savings account
                new JProperty("oauth_consumer_key", lCards.oauth_consumer_key)
                );
            return pin;
        }
        public JObject ShowCardJson(SyanpasePayLib.Resources.Cards lCards)
        {
            JObject pin = new JObject(
                new JProperty("id", lCards.legal_name),
                new JProperty("supp_id", lCards.supp_id),//id od the card u wish to add
                new JProperty("oauth_consumer_key", lCards.oauth_consumer_key)
                );
            return pin;
        }
    }
}
