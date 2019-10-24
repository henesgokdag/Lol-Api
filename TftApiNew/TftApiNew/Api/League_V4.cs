using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TftApiNew.Models;

namespace TftApiNew.Api
{
    public class League_V4 : Api
    {
        public League_V4()
        { }
        public List<LeagueEntryDTO> GetLeagueById(string SummonerId)
        {
            string path = "/league/v4/entries/by-summoner/" + SummonerId;
            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                
                return JsonConvert.DeserializeObject<List<LeagueEntryDTO>>(content);

            }
            else
            { return null; }
        }
    }
}