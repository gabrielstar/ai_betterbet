using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ai_betterbet.Model
{
    public class Team
    {
        public Team(int iD, string name, string league)
        {
            ID = iD;
            Name = name;
            League = league;
        }

        public int ID { get; set;}
        public string Name { get; set; }
        public string League { get; set; }
    }
}
