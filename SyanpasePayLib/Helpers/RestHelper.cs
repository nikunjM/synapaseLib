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

namespace SyanpasePayLib.Helpers
{
    public class RestHelper
    {
        public dynamic APICalls(JObject ljson, string endpoints, string method)
        {
            HttpWebRequest httpReq = (HttpWebRequest)HttprequestObject(endpoints, method);
            using (var streamWriter = new StreamWriter(httpReq.GetRequestStream()))
            {
                streamWriter.Write(ljson);
                streamWriter.Flush();
                streamWriter.Close();
            }
            var result = "";
            HttpWebResponse httpResponse;
            try
            {
                httpResponse = (HttpWebResponse)httpReq.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
            }
            catch (WebException e)
            {
                Console.WriteLine("This program is expected to throw WebException on successful run." +
                                    "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    Console.WriteLine("Status Code : {0}", ((HttpWebResponse)e.Response).StatusCode);
                    Console.WriteLine("Status Description : {0}", ((HttpWebResponse)e.Response).StatusDescription);
                    using (Stream data = e.Response.GetResponseStream())
                    using (var reader = new StreamReader(data))
                    {
                        string text = reader.ReadToEnd();
                        Console.WriteLine(text);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
            //return "Success";
            //not sure what to return 
            //here i have to add sql server code to enter into database
        }
        public dynamic APICalls(string ljson, string endpoints, string method)
        {
            HttpWebRequest httpReq = (HttpWebRequest)HttprequestObject(endpoints, method);
            using (var streamWriter = new StreamWriter(httpReq.GetRequestStream()))
            {
                streamWriter.Write(ljson);
                streamWriter.Flush();
                streamWriter.Close();
            }
            var result = "";
            HttpWebResponse httpResponse;
            try
            {
                httpResponse = (HttpWebResponse)httpReq.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
            }
            catch (WebException e)
            {
                Console.WriteLine("This program is expected to throw WebException on successful run." +
                                    "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    Console.WriteLine("Status Code : {0}", ((HttpWebResponse)e.Response).StatusCode);
                    Console.WriteLine("Status Description : {0}", ((HttpWebResponse)e.Response).StatusDescription);
                    using (Stream data = e.Response.GetResponseStream())
                    using (var reader = new StreamReader(data))
                    {
                        string text = reader.ReadToEnd();
                        Console.WriteLine(text);
                        result = text;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
            //return "Success";
            //not sure what to return 
            //here i have to add sql server code to enter into database
        }
        public HttpWebRequest HttprequestObject(string endpoints, string method)
        {
            string url = Settings.API_TEST_VALUE + endpoints;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = method;
            return httpWebRequest;
        }
        public void HttlpResponseObject(HttpWebRequest httpRes)
        {
            var httpResponse = (HttpWebResponse)httpRes.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
            //entry into databse can be done from here 
            //or it should return some value
        }
    }
}