using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class FaultDetailDto:IDto
    {   //Fault kısımlar 
        public string Area { get; set; }
        public string TechnicalBuilding { get; set; }
        public DateTime FaultDate { get; set; }
        public string FaultTime { get; set; }
        public string FaultDetail { get; set; }
        //FaultOff kısımlar 
        public DateTime ArrivalDate { get; set; }
        public string ArrivalTime { get; set; }
        public DateTime StartTime { get; set; }
        public int PersonelNumber { get; set; }
        public string WorkDoneOnTheFault { get; set; }
        public string SolutionAndCommet { get; set; }
        public string FaultStatus { get; set; }
    }
}
