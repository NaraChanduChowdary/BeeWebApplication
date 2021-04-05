using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeManager
{
    public class DroneBee : Bee
    {
        private const float deadpercentage = 50;
        public DroneBee()
        {
            DeadPercentage = deadpercentage;
        }
        public int DroneBeeId { get; set; }
    }
}
