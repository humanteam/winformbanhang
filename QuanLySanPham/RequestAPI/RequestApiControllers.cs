using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
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
