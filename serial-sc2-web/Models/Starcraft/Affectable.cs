using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serial_sc2_web.Models
{
    public class Affectable
    {

        //damage calcluation fields:
        protected float HitPoints { get; set; }

        /// Ground Attack
        protected float GAttack { get; set; }
        protected float Cooldown { get; set; }




        //unused so far... 

        // float Shields { get; set; }

        //refers to Affectable's "normal". Only laser giraffs (Colossus) can be both.
        //List<Elevation> Elevations { get; set; } 

        //refers to Affectable's "current". Only laser giraffs (Colossus) can be both.
        //List<Elevation> Altitudes { get; set; } 

        // these -->   biological, mechanical, armored or light ... 

        // Race Race { get; set; }



        //unit livability & attackability fields
        bool isDead { get; set; }
        bool isParalyzed { get; set; }


        //unit statistics fields:
        int attacksDone { get; set; } //change into a list of Affectables or list of meta stats-aff?
        int killsDone { get; set; }


        public void Attacks(Affectable other)
        {
            DoDamage(this, other)
        }

    }

    enum Race { TERRAN, ZERG, PROTOSS }

    enum Elevation { GROUND, AIR }

}
