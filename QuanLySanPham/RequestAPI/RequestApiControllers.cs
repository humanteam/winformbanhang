using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Xml;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace QuanLySanPham.RequestAPI
{
    class RequestApiControllers
    {
        public static bool _check_request(string body_request,string url)
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(body_request);
            Uri uri = new Uri(url);
            WebRequest request = WebRequest.Create(uri);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;

            using (var dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string strResponse = reader.ReadToEnd();
                if (strResponse.IndexOf("true")>0)
                {
                    return true;
                }
                else if (strResponse.IndexOf("false") > 0)
                {
                    return false;
                }
            }
            return false;
        }

        public static string reponse_json(string url)
        {
            Uri uri = new Uri(url);
            WebRequest request = WebRequest.Create(uri);
            request.Method = "GET";
            request.ContentType = "application/json; charset=utf-8";
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string strResponse = reader.ReadToEnd();
                parJson(strResponse);
                return strResponse;
            }
        }

        private static void parJson(string json)
        {
            JArray arr = JArray.Parse(json);
            int i = 0;
            foreach(JObject obj in arr)
            {
                Module.SanPham sp = JsonConvert.DeserializeObject<Module.SanPham>(obj.ToString());
                Module.SanPhams.listsp.Add(sp);
            }
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
