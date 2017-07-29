using System;
using System.Collections.Generic;

namespace SamuraiAppCore.Domains
{
    public class Buttle
    {
        public Buttle()
        {
            
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
    }
}
