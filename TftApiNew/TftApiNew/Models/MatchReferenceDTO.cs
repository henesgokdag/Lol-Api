﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TftApiNew.Models
{
    public class MatchReferenceDTO
    {
        public string lane { get; set; }
        public long gameId { get; set; }
        public int champion { get; set; }
        public string platformId { get; set; }
        public int season  {get; set; }
        public int queue { get; set; }

        public string role { get; set; }

        public long timestamp { get; set; }


    }
}