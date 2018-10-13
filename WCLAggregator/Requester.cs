using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCLAggregator
{
    public static class Requester
    {
        private static readonly HttpClient client = new HttpClient();
        private static string apiKey;
        
        //These handle class/spec specific requests for the rankings

        static Uri baseUri = new Uri("https://www.warcraftlogs.com/v1/");
        static Uri rankingsUri = new Uri(baseUri, "rankings/encounter/");
        
        public static void setApiKey(string apiKey){
            Requester.apiKey = apiKey;
        }

        private static string makeRequest(Uri requestUri, Dictionary<string, string> content){
            //common logic for making requests goes here- including dictionary to FormUrlEncodedContent conversion
            //and waiting for the request to finish

            //add in translation and api key, required for all requests
            content.Add("translate", "true");
            content.Add("api_key", Requester.apiKey);

            //plug parameters into uri

            string requestUriString = requestUri.ToString() + "?";

            foreach (string key in content.Keys)
            {
                requestUriString = requestUriString + HttpUtility.UrlEncode(key) + "=" + HttpUtility.UrlEncode(content[key]) + "&";
            }
            requestUriString = requestUriString.TrimEnd('&');
            requestUri = new Uri(requestUriString);
            
            //this isn't done asynchronously yet- maybe todo later
            HttpResponseMessage response = client.GetAsync(requestUri).Result;
            return response.Content.ReadAsStringAsync().Result;
        }

        public static List<Ranking> getRankings(Dictionary<string, string> parameters, int numberOfRanks, int encounterID) {
            //for getting a single encounter

            return getRankingPage(parameters, numberOfRanks, encounterID, 1);
        }

        public static List<Ranking> getRankings(Dictionary<string, string> parameters, int numberOfRanks, List<int> encounterIDs){
            //for getting multiple encounters

            List<Ranking> ranks = new List<Ranking>();
            foreach (int encounter in encounterIDs)
            {
                ranks.AddRange(getRankings(parameters, numberOfRanks, encounter));
            }
            return ranks;
        }

        public static List<Ranking> getRankingPage(Dictionary<string, string> parameters, int numberOfRanks, int encounterID, int page){
            
            parameters["page"] = page.ToString();

            Uri requestUri = new Uri(Requester.rankingsUri, encounterID.ToString());

            string rankString = makeRequest(requestUri, parameters);
            RankingContainer container = JsonConvert.DeserializeObject<RankingContainer>(rankString);
            List<Ranking> ranks = container.rankings;

            //We need to truncate the list down to the number requested if it is greater
            if(numberOfRanks < ranks.Count) {
                ranks = ranks.Take(numberOfRanks).ToList();
            }

            //Because the api returns only 100 ranks every request, we need to check
            //how many ranks are left and make another call for them
            int ranksLeft = container.getRankingsLeft(numberOfRanks);
            if(ranksLeft > 0){
                ranks.AddRange(getRankingPage(parameters, ranksLeft, encounterID, page + 1));
            }
            return ranks;
        }

        
    }
}
