namespace WCLAggregator
{
    public class EventAbsorbed
        : EventBase
    {
        public bool SourceIsFriendly { get; set; }
        public int TargetId { get; set; }
        public bool TargetIsFriendly { get; set; }
        public EventAbility Ability { get; set; }
        public int AttackerId { get; set; }
        public bool AttackerIsFriendly { get; set; }
        public int Amount { get; set; }
        public EventAbility ExtraAbility { get; set; }
    }
}
