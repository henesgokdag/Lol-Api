﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TftApiNew.Models
{
    public class PlayerDTO
    {
        public string currentPlatformId { get; set; }
        
        public string summonerName { get; set; }

        public string matchHistoryUri { get; set; }

        public string platformId { get; set; }

        public string currentAccountId { get; set; }

        public int profileIcon { get; set; }

        public string summonerId { get; set; }

        public string accountId { get; set; }
    }
}