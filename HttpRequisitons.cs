using System;

using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace ConsumindoWebApi
{
    class HttpRequisitons
    {
        public class Options
        {
            public object Auth { get; set; }
            public string PostData { get; set; }
            public string ContentType { get; set; }
        }
        public static object Get(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();

            return new System.IO.StreamReader(response.GetResponseStream()).ReadToEnd();
        }

        public static object Post(string url, Options options)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            var data = Encoding.ASCII.GetBytes(options.PostData);

            request.Method = "POST";
            request.ContentType = options.ContentType;
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse) request.GetResponse();

            return new StreamReader(response.GetResponseStream()).ReadToEnd();
        }
        public static object Put(string url, Options options)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            var data = Encoding.ASCII.GetBytes(options.PostData);

            request.Method = "PUT";
            request.ContentType = options.ContentType;
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            return new StreamReader(response.GetResponseStream()).ReadToEnd();
        }
        public static object Delete(string url, Options options = null)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "DELETE";

            if(options != null)
            {
                var data = Encoding.ASCII.GetBytes(options.PostData);
                request.ContentType = options.ContentType;
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }

            var response = (HttpWebResponse)request.GetResponse();

            return new StreamReader(response.GetResponseStream()).ReadToEnd();
        }
    }
}
