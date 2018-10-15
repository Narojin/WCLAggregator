namespace WCLAggregator
{
    public class EventSummon
        : EventBase
    {
        public bool SourceIsFriendly { get; set; }
        /// <summary>
        /// ID of the unit summoned
        /// </summary>
        public int TargetId { get; set; }
        /// <summary>
        /// Which instance of summoned unit this is
        /// </summary>
        public int TargetInstance { get; set; }
        public bool TargetIsFriendly { get; set; }
        public EventAbility Ability { get; set; }
    }
}
