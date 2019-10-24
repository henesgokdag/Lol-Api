using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TftApiNew.Models
{
    public class SummonerDTO
    {
        public int ProfileIconId { get; set; }
        public string Name { get; set; }
        public long SummonerLevel { get; set; }
        public string Id { get; set; }
        public string AccountId { get; set; }
    }
}