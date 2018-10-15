namespace WCLAggregator
{
    public class EventBase
    {
        public long Timestamp { get; set; }
        public string Type { get; set; }
        public int SourceId { get; set; }
    }
}
