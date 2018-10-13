using System.Collections.Generic;
namespace WCLAggregator{

    public class RankingContainer{
        int page;
        bool hasMorePages;
        int count;
        List<Ranking> rankings;
        
        public int getRankingsLeft(int ranks) {
            ranks = ranks - this.count;
            if(ranks < 0 || !this.hasMorePages){
                ranks = 0;
            }
            return ranks;
        }

        public List<Ranking> getRankings(){
            return this.rankings;
        }
    }

}