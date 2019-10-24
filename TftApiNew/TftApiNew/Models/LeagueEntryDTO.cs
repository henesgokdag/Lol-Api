using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TftApiNew.Models
{
    public class LeagueEntryDTO
    {
        public string queueType { get; set; }
        public int wins { get; set; }
        public int losses{ get; set; }
        public string rank { get; set; }
        public string tier { get; set; }
        public string summonerId { get; set; }
        public int leaguePoints { get; set; }
        
    }
}