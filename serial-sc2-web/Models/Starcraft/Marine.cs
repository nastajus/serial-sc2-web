using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serial_sc2_web.Models.Starcraft
{
    public class Marine : Affectable
    {
        public Marine()
        {
            HitPoints = 45;
            GAttack = 6;
            Cooldown = 0.61f;

            //annoyed it isn't easy to automate this in base class from values input in child class...
            HitPointsMax = HitPoints;
            HitPointsHypothetical = HitPoints;
        }
    }
}
