namespace WCLAggregator
{
    public class EventBeginCast
        : EventBase
    {
        public bool SourceIsFriendly { get; set; }
        public int TargetId { get; set; }
        public EventTarget Target { get; set; }
        public bool TargetIsFriendly { get; set; }
        public EventAbility Ability { get; set; }
    }
}
