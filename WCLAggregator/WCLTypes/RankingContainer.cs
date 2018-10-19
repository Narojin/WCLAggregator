using System.Collections.Generic;
namespace WCLAggregator{

    public class RankingContainer{
        public int page {get;}
        public bool hasMorePages {get;}
        public int count {get; set;}
        public List<Ranking> rankings {get;}
        
        public int getRankingsLeft(int ranks) {
            ranks = ranks - this.count;
            if(ranks < 0 || !this.hasMorePages){
                ranks = 0;
            }
            return ranks;
        }

    }

}