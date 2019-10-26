using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serial_sc2_web.Models.Report
{
    //assumptions:
    // no splash damage, attacks are instantaneous, first parameter goes first so is biased towards that unit etc, assumed in range (even impossible case of long range siege tank in siege mode against melee zealot, both would artifically successfully hit each other in earliest prototype)
    public class ReportBattleOneVersusOne
    {
        //stats
        Affectable winner { get; set; } //=> use 1-liner lambda to search table with linq, and possibly return null or return "NOT YET"...

        Affectable loser { get; set; } 
        List<Affectable> tied { get; set; }

        List<ReportChange> changesTable = new List<ReportChange>(); //when is it good to init list??

        
        
        //abilities

        void AddChangeSample(ReportChange change) { changesTable.Add(change); }


        public class CompetitorStatus {
            List<Affectable> Competitors;
            CompetitorStatus Status;
            CompetitorStatus(List<Affectable> competitors, CompetitorStatus status)
            {
                Competitors = competitors;
                Status = status;
            }
        }


    }

    public enum CompetitorStatus { WINNER, LOSER, TIED }
}
