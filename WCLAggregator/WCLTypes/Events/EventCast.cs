using System.Collections.Generic;
namespace WCLAggregator
{
    public class EventCast
        : EventBase
    {
        public bool SourceIsFriendly { get; set; }
        public int TargetId { get; set; }
        public bool TargetIsFriendly { get; set; }
        public EventAbility Ability { get; set; }
        /// <summary>
        /// Cast = resources of the source before hand
        /// </summary>
        public int ResourceActor { get; set; }
        public List<EventClassResource> ClassResources { get; set; }
        public long HitPoints { get; set; }
        public long MaxHitPoints { get; set; }
        public int AttackPower { get; set; }
        public int SpellPower { get; set; }
        /// <summary>
        /// ?
        /// </summary>
        public int Resolve { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int ItemLevel { get; set; }
    }
}
