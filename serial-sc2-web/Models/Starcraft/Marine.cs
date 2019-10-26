using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serial_sc2_web.Models
{
    public class Marine : Affectable
    {
        Marine()
        {
            HitPoints = 45;
            GAttack = 6;
            Cooldown = 0.61f;
        }
    }
}
