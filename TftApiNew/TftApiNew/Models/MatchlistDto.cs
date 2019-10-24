using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TftApiNew.Models
{
    public class MatchlistDTO
    {
        public List<MatchReferenceDTO> matches { get; set; }
        public int totalGames { get; set; }
        public int startIndex { get; set; }
        public int endIndex { get; set; }

    
    }
}