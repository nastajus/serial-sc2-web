using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serial_sc2_web.Models
{
    public class Zergling : Affectable
    {
        Zergling()
        {
            HitPoints = 35;
            GAttack = 5;
            Cooldown = 0.497f;
        }
    }
}
