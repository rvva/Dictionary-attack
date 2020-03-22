using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace BruteForce
{
    class HttpMethod
    {
        public static string GETtoString(string URL, string refer, CookieContainer cookie)
        {
            HttpWebRequest GET_request = (HttpWebRequest)WebRequest.Create(URL);
            GET_request.Method = "GET";
            GET_request.CookieContainer = cookie;
            GET_request.Referer = refer;
            GET_request.UserAgent = "";

            HttpWebResponse webResponse = (HttpWebResponse)GET_request.GetResponse();
            cookie.Add(webResponse.Cookies);

            string pageSource;
            StreamReader streamReader = new StreamReader(webResponse.GetResponseStream());
            pageSource = streamReader.ReadToEnd();

            return pageSource;
        }

        public static bool POSTtoString(string URL, string postData, string refer,
             CookieContainer cookie)
        {
            string key = "Hasło nieprawidłowe!";
            HttpWebRequest POST_request = (HttpWebRequest)WebRequest.Create(URL);
            POST_request.Method = "POST";
            POST_request.Host = "tendawifi.com";
            POST_request.CookieContainer = cookie;
            POST_request.Referer = refer;
            POST_request.UserAgent = "";
            POST_request.ContentType = "application/x-www-form-urlencoded";
            POST_request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";

            Stream postStream = POST_request.GetRequestStream();
            byte[] postBytes = Encoding.ASCII.GetBytes(postData);
            postStream.Write(postBytes, 0, postBytes.Length);
            postStream.Dispose();

            HttpWebResponse response = (HttpWebResponse)POST_request.GetResponse();
            cookie.Add(response.Cookies);

            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            string pageSrc = streamReader.ReadToEnd();

            return (!pageSrc.Contains(key));
        }
    }
}


