using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TftApiNew.Models;

namespace TftApiNew.Api
{
    public class Match_V4 : Api
    {
        public Match_V4()
        { }



        public MatchlistDTO GetMatchlistById(String SummonerId)
        {
            string path = "/match/v4/matchlists/by-account/" + SummonerId;
            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<MatchlistDTO>(content);

            }
            else
            { return null; }
        }

        public MatchDTO GetMatchListByMatchId(long matchId)

        {
            string path = "/match/v4/matches/" + matchId;
            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<MatchDTO>(content);

            }
            else
            { return null; }
        }
    }
}
