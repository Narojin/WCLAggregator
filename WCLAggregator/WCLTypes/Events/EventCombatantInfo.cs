using System.Collections.Generic;

namespace WCLAggregator
{
    public class EventCombatantInfo
        : EventBase
    {
        public int SpecId { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Stamina { get; set; }
        public int Intellect { get; set; }
        public int Armor { get; set; }
        public int CritSpell { get; set; }
        public int Speed { get; set; }
        public int Leech { get; set; }
        public int HasteSpell { get; set; }
        public int Avoidance { get; set; }
        public int Mastery { get; set; }
        public int VersatilityHealingDone { get; set; }
        public int VersatilityDamageReduction { get; set; }

        public List<EventTalent> Talents { get; set; }
        public List<EventArtifact> Artifact { get; set; }
        public List<EventGear> Gear { get; set; }
        public List<EventAura> Auras { get; set; }
    }
}
