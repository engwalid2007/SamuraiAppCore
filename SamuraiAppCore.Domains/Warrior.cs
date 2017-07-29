using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiAppCore.Domains
{
    public class Warrior
    {
        public int WarriorId { get; set; }
        public string Name { get; set; }
        public int SamuraiId { get; set; }
        public Samurai Samurai { get; set; }
    }
}
