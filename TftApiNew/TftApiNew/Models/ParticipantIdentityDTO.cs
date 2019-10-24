using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TftApiNew.Models
{
    public class ParticipantIdentityDTO
    {
        public PlayerDTO player { get; set; }
        public int participantId { get; set; }
    }
}