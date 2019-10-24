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
    public class SummonerIdController : ApiController
    {
        // GET: SummonerId
        public SummonerDTO Get(string Id)
        {
            Summoner_V4 summoner_V4 = new Summoner_V4();
            var summoner = summoner_V4.GetSummonerById(Id);
            return summoner;

        }
    }
}