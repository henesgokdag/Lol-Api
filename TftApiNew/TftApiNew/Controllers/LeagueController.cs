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
    public class LeagueController : ApiController
    {
        // GET: League
        public List<LeagueEntryDTO> Get(string summonerId)
        {
            League_V4 league_V4= new League_V4();
            var league = league_V4.GetLeagueById(summonerId);
            return league;

        }
    }
}