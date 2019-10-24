using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using TftApiNew.Api;
using TftApiNew.Models;

namespace TftApiNew.Controllers
{
    public class SummonerNameController : ApiController
    {
        // GET: SummonerName
        public SummonerDTO Get(string summonerName)
        {
            Summoner_V4 summoner_V4 = new Summoner_V4();
            var summoner = summoner_V4.GetSummonerByName(summonerName);
            return summoner;

        }
    }
}