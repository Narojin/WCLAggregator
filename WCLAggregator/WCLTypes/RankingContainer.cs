using System.Collections.Generic;
namespace WCLAggregator{

    public class RankingContainer{
        public int page {get; set;}
        public bool hasMorePages {get; set;}
        public int count {get; set;}
        public List<Ranking> rankings {get; set;}
        
        public int getRankingsLeft(int ranks) {
            ranks = ranks - this.count;
            if(ranks < 0 || !this.hasMorePages){
                ranks = 0;
            }
            return ranks;
        }

    }

}