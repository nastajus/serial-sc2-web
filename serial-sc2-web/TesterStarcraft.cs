using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using serial_sc2_web.Models.Report;
using serial_sc2_web.Data;

namespace serial_sc2_web
{
    public static class TesterStarcraft
    {
        public static void Test()
        {
            ReportBattle1v1 report = new ReportBattle1v1();
            var battle = MockBattleSequences.Battle01_ZerglingVsMarine().ToList();
            var winner = report.CalculateWinner(battle);
            Console.WriteLine($"winner is {winner.GetType().Name}");
            Console.ReadKey();
        }
    }
}
