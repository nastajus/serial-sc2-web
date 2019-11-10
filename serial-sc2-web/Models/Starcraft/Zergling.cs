using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serial_sc2_web.Models.Starcraft
{
    public class Zergling : Affectable
    {
        public Zergling()
        {
            HitPoints = 35;
            GAttack = 5;
            Cooldown = 0.497f;

            //annoyed it isn't easy to automate this in base class from values input in child class...
            HitPointsMax = HitPoints;
            HitPointsHypothetical = HitPoints;
        }
    }
}
