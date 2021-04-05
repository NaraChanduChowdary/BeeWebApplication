using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeManager
{
    public abstract class Bee
    {
        public Bee()
        {
            Health = 100;
        }
        protected float DeadPercentage { get; set; }
        public float Health { get; set; }

        public bool IdBeeDead
        {
            get
            {
                return (Health < DeadPercentage) ? true : false;

            }
        }

        public void Damage(int perecentageOfDamage)
        {
            if (perecentageOfDamage >= 0 && perecentageOfDamage <= 100)
            {
                if (Health >= DeadPercentage)
                {
                    Health = Health - (Health * ((float)perecentageOfDamage / 100));
                }
            }
        }
    }
}
