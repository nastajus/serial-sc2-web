using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using serial_sc2_web.Models.Report;
using serial_sc2_web.Services;

namespace serial_sc2_web.Models.Starcraft
{
    public abstract class Affectable
    {

        //public 
        public float BaseDamage { get { return GAttack; } } //very simple for now.
        public float BonusDamage { get { return 0; } }
        public float AttackUpgrades { get; private set; }


        //damage calcluation fields:
        protected float HitPoints { get; set; }         //== HealthPoints
        protected float HitPointsMax { get; set; }      //== HealthPointsMax

        protected float HitPointsHypothetical { get; set; }

        /// Ground Attack
        protected float GAttack { get; set; }
        protected float Cooldown { get; set; }




        //unused so far... 

        float ShieldPoints { get; set; }
        protected float ShieldPointsMax { get; set; }

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


        public ReportChange UseAbility(Affectable target)
        {
            return new ReportChange();
        }

        //applies always to self, and always increments by 1 (i think, to follow sc2 closely)
        public ReportChange Upgrade(Upgrade upgrade)
        {
            return new ReportChange();
        }


        public ReportChange Attacks(Affectable other)
        {
            var damage = Mechanics.DamageFormula(this, other);
            ApplyDamage(damage);
            //this.ApplyDamage(damage);

            ReportChange changes = new ReportChange { 
                Initiator = this, 
                Activity = ActivityType.ATTACKS, 
                Recepient = other,
                HitPointChange = damage //for now...
            };

            if (other.isDead)
            {
                changes.VitalStatusChangedToDead = true;
            }

            return changes;
        }

        private void ApplyDamage(float damage)
        {
            var damageRemaining = damage;
            //if (ShieldPointsMax > 0)
            //{
            //    damageRemaining -= ShieldPoints;
            //    //...
            //}
            if (damageRemaining > 0)
            {
                var healthDamage = HitPoints - damageRemaining;

                //when exceeds unit health points, just set actual hit points to zero
                HitPoints = (healthDamage < 0) ? 0 : healthDamage;
                isDead = (HitPoints == 0); // ? true : false;

                //keep counting negative points for hypothetical calcluations
                HitPointsHypothetical -= healthDamage; 

            }
        }

    }

    public enum Race { TERRAN, ZERG, PROTOSS }

    public enum Elevation { GROUND, AIR }

    public enum Upgrade {  }

}
