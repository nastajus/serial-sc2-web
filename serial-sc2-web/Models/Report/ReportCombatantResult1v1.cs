using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using serial_sc2_web.Models.Starcraft;

namespace serial_sc2_web.Models.Report
{
    public class ReportCombatantResult1v1
    {
        //public CombatResultState1v1 Result { get; set; }
        public Affectable Winner { get; set; }
        public Affectable Loser { get; set; }
        public List<Affectable> Tied;

        public ReportCombatantResult1v1(Affectable Winner, Affectable Loser)
        {
            this.Winner = Winner;
            this.Loser = Loser;
            //this.Result = CombatResultState1v1.WINNER_AND_LOSER;
        }

        public ReportCombatantResult1v1(List<Affectable> Tied)
        {
            //this.Result = CombatResultState1v1.TIE;
        }

    }

    //public enum CombatResultState1v1 { UNRESOLVED, WINNER_AND_LOSER, TIE }
}
