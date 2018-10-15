using System.Collections.Generic;

namespace WCLAggregator
{
    public class EventGear
    {
        public int Id { get; set; }
        public int ItemLevel { get; set; }
        public int Quality { get; set; }
        public string Icon { get; set; }
        public int PermanentEnchant { get; set; }
        public int OnUseEnchant { get; set; }
        /// <summary>
        /// TODO: Fill this out if it's needed
        /// </summary>
        public List<int> BonusIds { get; set; }
        /// <summary>
        /// TODO: Fill this out if it's needed
        /// </summary>
        public object Gems { get; set; }
    }
}
