
namespace WCLAggregator
{
    public class EventApplyBuffStack
        : EventBase
    {
        public bool SourceIsFriendly { get; set; }
        public int TargetId { get; set; }
        public bool TargetIsFriendly { get; set; }
        public EventAbility Ability { get; set; }
        public int Stacks { get; set; }

    }
}
