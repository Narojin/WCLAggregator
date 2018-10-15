using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WCLAggregator
{
    public class EventApplyDebuff
        : EventBase
    {
        public bool SourceIsFriendly { get; set; }
        public int TargetId { get; set; }
        public bool TargetIsFriendly { get; set; }
        public EventAbility Ability { get; set; }
    }
}
