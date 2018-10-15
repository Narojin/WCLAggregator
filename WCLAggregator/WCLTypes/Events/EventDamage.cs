using System.Collections.Generic;

namespace WCLAggregator
{
    public class EventDamage
        : EventBase
    {
        public bool SourceIsFriendly { get; set; }
        public int TargetId { get; set; }
        public bool TargetIsFriendly { get; set; }
        public EventAbility Ability { get; set; }
        /// <summary>
        /// 1 is a successful hit
        /// </summary>
        public int HitType { get; set; }
        public int Amount { get; set; }
        public int Absorbed { get; set; }
        /// <summary>
        /// Damage = resources of the target after
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
