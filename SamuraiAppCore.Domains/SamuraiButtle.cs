using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiAppCore.Domains
{
    public class SamuraiButtle
    {
        public int SamuraiId { get; set; }
        public Samurai Samurai { get; set; }
        public int ButtleId { get; set; }
        public Buttle Buttle { get; set; }
    }
}
