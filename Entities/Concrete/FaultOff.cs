using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public  class FaultOff:IEntity
    {
        public int FaultOffId { get; set; }
        public int FaultEqualId { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string ArrivalTime { get; set; }
        public DateTime StartTime { get; set; }
        public int PersonelNumber { get; set; }
        public string  WorkDoneOnTheFault { get; set; }
        public string SolutionAndCommet { get; set; }
        public string FaultStatus { get; set; }
    }
}
        