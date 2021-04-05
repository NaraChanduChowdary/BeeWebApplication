using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeManager
{
    public class QueenBee : Bee
    {
        private const float deadpercentage = 20;
        public QueenBee()
        {
            DeadPercentage = deadpercentage;
        }
        public int QueenBeeId { get; set; }
    }
}
