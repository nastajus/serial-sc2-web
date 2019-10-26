using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using serial_sc2_web.Models.Starcraft;

namespace serial_sc2_web.Models.Report
{
    //tracks just the key details that determine winner/loser outcomes in singular 1v1 interactions, 
    //as well as general updates like "unit received upgrade", "unit healed", "unit start conditions"

    //i'm debating whether to report *just* changes *only*, or a mix with full-status updates...
    //i'll *try* adhering to *just changes* for the moment.

    //change reports "shouldn't be smart enough to decide won/loss, let the receiving aggregator ReportBattle do that.

    public class ReportChange
    {
        public Affectable Initiator { get; set; }
        public ActivityType Activity { get; set; }
        public Affectable Recepient { get; set; }

        public string DescriptionOfChange { get; set; }
        public float HitPointChange { get; set; }
        public int AttacksDoneChange { get; set; }
        public bool VitalStatusChangedToDead { get; set; }
        public int KillsDoneChange { get; set; }
        public float TimeCoolingChange { get; set; }

        public ReportChange() { }

        public ReportChange(Affectable initiator, ActivityType activity, Affectable recepient)
        {
            Initiator = initiator;
            Activity = activity;
            Recepient = recepient;
        }
    }
    public enum ActivityType { ATTACKS, USE_ABILITY_ON } //USE_SPELL
}
