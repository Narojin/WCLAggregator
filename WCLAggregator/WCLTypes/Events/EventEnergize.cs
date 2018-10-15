using System.Collections.Generic;
namespace WCLAggregator
{
    public class EventEnergize
        : EventBase
    {
        public bool SourceIsFriendly { get; set; }
        public int TargetId { get; set; }
        public bool TargetIsFriendly { get; set; }
        public EventAbility Ability { get; set; }
        public int ResourceChange { get; set; }
        /// <summary>
        /// 0 = Mana
        /// </summary>
        public int ResourceChangeType { get; set; }
        public int OtherResourceChange { get; set; }
        public int Waste { get; set; }
        /// <summary>
        /// It's always either 1 or 2 (target or source)
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
