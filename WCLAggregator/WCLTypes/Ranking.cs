using System;
using System.Collections.Generic;

namespace WCLAggregator
{
    public class Ranking
    {
        public string name {get;}
        public int @class {get;}
        public int spec {get;}
        public float total {get;}
        public int duration {get;}
        public UInt64 startTime {get;}
        public UInt64 fightID {get;}
        public string reportID {get;}
        public string guildName {get;}
        public string serverName {get;}
        public string regionName {get;}
        public string hidden {get;}
        public int itemLevel {get;}
        public int exploit {get;}
        public List<Talent> talents {get;}
        public List<Gear> gear {get;}
        public List<AzeritePower> azeritePowers {get;}
        public int size {get;}

    }
}
