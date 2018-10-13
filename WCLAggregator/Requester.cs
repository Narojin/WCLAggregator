using System;
using Newtonsoft.Json;
using System.Net.Http;

namespace WCLAggregator
{
    public class Requester
    {
        private static readonly HttpClient client = new HttpClient();
        private string apiKey;

        //These handle class/spec specific requests for the rankings
        private int classID;
        private int specID;

        static Uri baseUri = new Uri("https://www.warcraftlogs.com/v1/");
        Uri rankingsUri = new Uri(baseUri, "rankings/encounter/");

        static private Requester instance;
        
        Requester(string apiKey){
            this.apiKey = apiKey;
        }

        private string makeRequest(Uri requestUri, HttpContent content){
            //common logic for making requests goes here- including dictionary to httpcontent conversion
            //and waiting for the request to finish
            
            //this isn't done asynchronously yet- maybe todo later
            HttpResponseMessage response = client.PostAsync(requestUri, content).Result;
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
