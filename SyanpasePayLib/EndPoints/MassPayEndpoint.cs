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
    public class MassPayEndpoint
    {
        public string AddMassPayRequestByCard(List<MassPay> lMassPay)
        {
            RestHelper lhelp = new RestHelper();
            string ljson = AddMassPatRequestJson(lMassPay);
            string results = lhelp.APICalls(ljson, Settings.Add_MASS_PAY_REQUEST_BYCARDS_ENDPOINT, Settings.Add_MASS_PAY_REQUEST_METHOD);
            return results;
        }

        public string AddMassPayRequest(List<MassPay> lMassPay)
        {
            RestHelper lhelp = new RestHelper();
            
            string ljson = AddMassPatRequestUserInfoJson(lMassPay);
            string results = lhelp.APICalls(ljson, Settings.Add_MASS_PAY_REQUEST_ENDPOINT, Settings.Add_MASS_PAY_REQUEST_METHOD);
            return results;
        }

        
   
        public string AddMassPatRequestJson(List<MassPay> lMassPay)
        {

            StringBuilder sb = new StringBuilder();
            JsonWriter jw = new JsonTextWriter(new StringWriter(sb));

            jw.Formatting = Formatting.Indented;
            jw.WriteStartObject();
            jw.WritePropertyName("oauth_consumer_key");
            jw.WriteValue("asdasdsadasdas");
            jw.WritePropertyName("mass_pays");
            jw.WriteStartArray();
            
             for (int i = 0; i < lMassPay.Count; i++)
            {
                jw.WriteStartObject();
                jw.WritePropertyName("legal_name");
                jw.WriteValue(lMassPay[i].legal_name);
                jw.WritePropertyName("account_number");
                jw.WriteValue(lMassPay[i].account_number);
                jw.WritePropertyName("routing_number");
                jw.WriteValue(lMassPay[i].routing_number);
                jw.WritePropertyName("amount");
                jw.WriteValue(lMassPay[i].amount);
                jw.WritePropertyName("trans_type");
                jw.WriteValue(lMassPay[i].trans_type);
                jw.WritePropertyName("account_class");
                jw.WriteValue(lMassPay[i].account_class);
                jw.WritePropertyName("account_type");
                jw.WriteValue(lMassPay[i].account_type);
                jw.WritePropertyName("status_url");
                jw.WriteValue(lMassPay[i].status_url);
                jw.WritePropertyName("supp_id");
                jw.WriteValue(lMassPay[i].supp_id);
                jw.WriteEndObject();
            }
            jw.WriteEndArray();
            jw.WriteEndObject();
            return sb.ToString();
        }

        public string AddMassPatRequestUserInfoJson(List<MassPay> lMassPay)
        {

            StringBuilder sb = new StringBuilder();
            JsonWriter jw = new JsonTextWriter(new StringWriter(sb));

            jw.Formatting = Formatting.Indented;
            jw.WriteStartObject();
            jw.WritePropertyName("oauth_consumer_key");
            jw.WriteValue("cb087f3548d44a78797a93a689a78b42623c2447");
            jw.WritePropertyName("bank_id");
            jw.WriteValue("");
            jw.WritePropertyName("facilitator_fee");
            jw.WriteValue("0.11");
            
            jw.WritePropertyName("mass_pays");
            jw.WriteStartArray();
            for (int i = 0; i < lMassPay.Count; i++)
            {
                jw.WriteStartObject();
                jw.WritePropertyName("legal_name");
                jw.WriteValue(lMassPay[i].legal_name);
                jw.WritePropertyName("account_number");
                jw.WriteValue(lMassPay[i].account_number);
                jw.WritePropertyName("routing_number");
                jw.WriteValue(lMassPay[i].routing_number);
                jw.WritePropertyName("amount");
                jw.WriteValue(lMassPay[i].amount);
                jw.WritePropertyName("trans_type");
                jw.WriteValue(lMassPay[i].trans_type);
                jw.WritePropertyName("account_class");
                jw.WriteValue(lMassPay[i].account_class);
                jw.WritePropertyName("account_type");
                jw.WriteValue(lMassPay[i].account_type);
                jw.WritePropertyName("status_url");
                jw.WriteValue(lMassPay[i].status_url);
                jw.WritePropertyName("supp_id");
                jw.WriteValue(lMassPay[i].supp_id);
                jw.WritePropertyName("user_info");
                jw.WriteStartArray();

                jw.WriteStartObject();
                jw.WritePropertyName("email");
                jw.WriteValue(lMassPay[i].user.email);
                jw.WritePropertyName("phone_number");
                jw.WriteValue(lMassPay[i].user.phone_number);
                jw.WritePropertyName("ip_address");                    
                jw.WriteValue(lMassPay[i].user.ip_address);
                jw.WritePropertyName("dob");
                jw.WriteValue(lMassPay[i].user.dob);
                jw.WritePropertyName("risk_score");
                jw.WriteValue(lMassPay[i].user.risk_score);
                jw.WritePropertyName("ssn");
                jw.WriteValue(lMassPay[i].user.ssn);
                jw.WriteEndObject();
                jw.WriteEndArray();
                jw.WriteEndObject();
            }
            jw.WriteEndArray();
            jw.WriteEndObject();
            return sb.ToString();
        }

            /*
            var lstDp = new List<MassPayList> {
            new MassPayList {
                oauth_consumer_key = "NY",
                bank_id="111111",
                facilitator_fee ="0.10",
                new MassPay 
                { 
                legal_name="Nikunj mange",
                account_number="11",
                routing_number="",
                amount="asd",
                trans_type="a",
                account_class="asd",
                account_type="dasd",
                status_url="asd",
                supp_id="asd",
                user_info="asd"
                },
                new MassPay{ 
                legal_name="Nikunj mange",
                account_number="11",
                routing_number="",
                amount="asd",
                trans_type="a",
                account_class="asd",
                account_type="dasd",
                status_url="asd",
                supp_id="asd",
                user_info="asd"
                },
                { 
                legal_name="Nikunj mange",
                account_number="11",
                routing_number="",
                amount="asd",
                trans_type="a",
                account_class="asd",
                account_type="dasd",
                status_url="asd",
                supp_id="asd",
                user_info="asd"
                }
            }
        };
            return json;
        }*/


    }
}
