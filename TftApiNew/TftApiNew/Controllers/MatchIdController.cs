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
    public class MatchIdController : ApiController
    {
        // GET: MatchId
        public MatchDTO Get(long matchId)
        {
            Match_V4 match_V4 = new Match_V4();
            var match = match_V4.GetMatchListByMatchId(matchId);
            return match;

        }
    }
}