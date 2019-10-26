using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using serial_sc2_web.Models.Starcraft;

namespace serial_sc2_web.Models.Report
{
    //assumptions:
    // no splash damage, attacks are instantaneous, first parameter goes first so is biased towards that unit etc, assumed in range (even impossible case of long range siege tank in siege mode against melee zealot, both would artifically successfully hit each other in earliest prototype)
    public class ReportBattle1v1
    {
        //stats
        //Affectable winner { get; set; } //=> use 1-liner lambda to search table with linq, and possibly return null or return "NOT YET"...
        //Affectable loser { get; set; } 
        //List<Affectable> tied { get; set; }

        public Affectable Winner { get { return changesTable.FirstOrDefault(change => change.VitalStatusChangedToDead).Initiator; } }

        public Affectable Loser { get { return changesTable.FirstOrDefault(change => change.VitalStatusChangedToDead).Recepient; } }

        List<ReportChange> changesTable = new List<ReportChange>(); //when is it good to init list??

        
        
        //abilities
        void AddChangeSample(ReportChange change) { changesTable.Add(change); } //i question why use..



        public void PopulateChangesTable(List<ReportChange> actions)
        {
            //if (actions == null) { return;  } //when need..?
            foreach (var action in actions)
            {
                AddChangeSample(action);
            }
        }

        public ReportCombatantResult1v1 CalculateWinner()
        {
            //evaluate winner/loser based on isDead... with lambda properties... done.
            return new ReportCombatantResult1v1(Winner, Loser);
        }



        //loop with polling rate
        public void CalculateWinner(Affectable a, Affectable b)
        {

        }


    }

    public enum CompetitorStatus { WINNER, LOSER, TIED }
}
