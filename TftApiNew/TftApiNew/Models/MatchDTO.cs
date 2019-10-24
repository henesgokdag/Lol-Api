﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TftApiNew.Models
{
    public class MatchDTO
    {
        public int seasonId { get; set; }
        public int queueId { get; set; }
        public long gameId { get; set; }
        public List<ParticipantIdentityDTO> participantIdentities { get; set; }

        public string gameVersion { get; set; }

        public string platformId { get; set; }
        public string gameMode { get; set; }

        public int mapId { get; set; }

        public string gameType { get; set; }

        public List<TeamStatsDTO> teams { get; set; }

        public  List<ParticipantDTO> participants { get; set; } 

        public long gameDuration { get; set; }

        public long gameCreation { get; set; }
    }
}