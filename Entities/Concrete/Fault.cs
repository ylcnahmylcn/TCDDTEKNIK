using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Fault:IEntity
    {
        public int FaultId { get; set; }
        public int FaultEqualId { get; set; }
        public string Area { get; set; }
        public string  TechnicalBuilding { get; set; }
        public DateTime FaultDate { get; set; }
        public string FaultTime { get; set; }
        public string  FaultKM { get; set; }
        public string  Scope { get; set; }
        public string FaultDetail { get; set; }
        public string Team { get; set; }
    }
}
