using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeManager
{
    public class Workerbee : Bee
    {
        private const float deadpercentage = 70;
        public Workerbee()
        {
            DeadPercentage = deadpercentage;
        }
        public int WorkerBeeId { get; set; }
    }
}
