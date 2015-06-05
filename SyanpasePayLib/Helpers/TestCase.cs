using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using System.Net;
using System.IO;


namespace WebApiTest.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://sandbox.synapsepay.com/api/v2/bank/login");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                
                string json = "{\"oauth_consumer_key\":\"aaaanikuaaaaaanjaa@synapsepay.com\"," +
                              "\"fullname\":\"nik\"," +
                              "\"phonenumber\":\"111\"," +
                              "\"ip_address\":\"1.1.1.1.1\"," +
                              "\"password\":\"123123123\"," +
                              "\"client_id\":\"836db45feb835d2cd5d2\"," +
                              "\"client_secret\":\"ca1c5db06d50d047ac294f4acb31cf0958bcfdf6\"}";

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
          }
        
    }
}
         