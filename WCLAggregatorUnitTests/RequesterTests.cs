using System.Collections.Generic;
using Newtonsoft.Json;
using System;
using Xunit;

namespace WCLAggregatorUnitTests
{
    public class RequesterTests
    {
        [Fact]
        public void EventParserTest()
        {
            List<WCLAggregator.EventBase> events = new List<WCLAggregator.EventBase>();
            events.Add(JsonConvert.DeserializeObject<WCLAggregator.EventDamage>("{ \"timestamp\": 1258128, \"type\": \"damage\", \"sourceID\": 84, \"sourceIsFriendly\": true, \"targetID\": 114, \"targetIsFriendly\": false, \"ability\": { \"name\": \"Melee\", \"guid\": 1, \"type\": 1, \"abilityIcon\": \"inv_axe_02.jpg\" }, \"hitType\": 1, \"amount\": 2845, \"mitigated\": 1219, \"unmitigatedAmount\": 4064, \"absorbed\": 0, \"resourceActor\": 2, \"classResources\": [ { \"amount\": 3, \"max\": 100, \"type\": 3 } ], \"hitPoints\": 44654048, \"maxHitPoints\": 74585600, \"attackPower\": 0, \"spellPower\": 0, \"armor\": 2700, \"x\": 25213, \"y\": -26114, \"facing\": 281, \"mapID\": 1148, \"itemLevel\": 123 }"));
            var parsed = WCLAggregator.Requester.parseEvents("{events : [{ \"timestamp\": 1258128, \"type\": \"damage\", \"sourceID\": 84, \"sourceIsFriendly\": true, \"targetID\": 114, \"targetIsFriendly\": false, \"ability\": { \"name\": \"Melee\", \"guid\": 1, \"type\": 1, \"abilityIcon\": \"inv_axe_02.jpg\" }, \"hitType\": 1, \"amount\": 2845, \"mitigated\": 1219, \"unmitigatedAmount\": 4064, \"absorbed\": 0, \"resourceActor\": 2, \"classResources\": [ { \"amount\": 3, \"max\": 100, \"type\": 3 } ], \"hitPoints\": 44654048, \"maxHitPoints\": 74585600, \"attackPower\": 0, \"spellPower\": 0, \"armor\": 2700, \"x\": 25213, \"y\": -26114, \"facing\": 281, \"mapID\": 1148, \"itemLevel\": 123 }]}");
            Assert.Equal(parsed[0].Timestamp, events[0].Timestamp);
            Assert.Equal(parsed[0].Type, events[0].Type);
            Assert.Equal(parsed[0].GetType(), events[0].GetType());
            Assert.Equal(parsed[0].Type, events[0].Type);
        }
    }
}
