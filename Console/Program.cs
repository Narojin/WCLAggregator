using System;
using WCLAggregator;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cdacdsa = new Dictionary<string, string>();
            cdacdsa.Add("metric", "hps");

            WCLAggregator.Requester.setApiKey("6f5214bba2c2ed4cad6800c6a57c3118");

            List<Ranking> ranks = WCLAggregator.Requester.getRankings(cdacdsa, 150, 2144);
            foreach (Ranking rank in ranks)
            {
                Console.WriteLine(rank.name);
            }
        }
    }
}
