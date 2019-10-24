using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace TftApiNew.Api
{
    public class Api
    {
        public string Key { get; set; }
        public string Region { get; set; }
        public Api()
        {
           
        }
        protected HttpResponseMessage GET(string URL)
        {
            using (HttpClient client = new HttpClient())
            {
                var result = client.GetAsync(URL);
                result.Wait();
                return result.Result;
            }
        }
        protected string GetURI(string path)
        {
            return "https://tr1.api.riotgames.com/lol" + path + "?api_key=YOUR KEY HERE";
        }
        public string GetKey(string path)
        {
            StreamReader sr = new StreamReader(path);
            return sr.ReadToEnd();
        }
    }
}