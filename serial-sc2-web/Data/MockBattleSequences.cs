using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using serial_sc2_web.Models.Report;
using serial_sc2_web.Models.Starcraft;

namespace serial_sc2_web.Data
{
    public static class MockBattleSequences
    {
        public static IEnumerable<ReportChange> Battle01_ZerglingVsMarine_BothDie()
        {
            Zergling zergling = new Zergling();
            Marine marine = new Marine();
            yield return zergling.Attacks(marine);
            yield return marine.Attacks(zergling);
            yield return zergling.Attacks(marine);
            yield return marine.Attacks(zergling);
            yield return zergling.Attacks(marine);
            yield return marine.Attacks(zergling);
            yield return zergling.Attacks(marine);
            yield return marine.Attacks(zergling);
            yield return zergling.Attacks(marine);
            yield return marine.Attacks(zergling);
            yield return zergling.Attacks(marine); //twice!
            yield return zergling.Attacks(marine);
            yield return marine.Attacks(zergling); //marine kills zergling

            //hypothetical calculations past zergling death
            yield return zergling.Attacks(marine);
            yield return marine.Attacks(zergling);
            yield return zergling.Attacks(marine); //hypothetical zergling kills marine finally

            //yield return null;
        }

    }
}
