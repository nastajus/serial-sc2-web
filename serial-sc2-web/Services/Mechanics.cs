using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using serial_sc2_web.Models.Starcraft;

namespace serial_sc2_web.Services
{
    public static class Mechanics
    {
        public static float DamageFormula(Affectable attacker, Affectable receiver) {
            //all floats for now ... not sure how to resolve internal floats to visible ints... (how does SC2 round this, or is it hidden?)
            var damage = (attacker.BaseDamage + attacker.BonusDamage + attacker.AttackUpgrades);
            return damage;

        }
    }
}
