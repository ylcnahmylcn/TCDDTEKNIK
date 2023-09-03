using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public  class TCDDContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TCDDteknikDB;Trusted_Connection=true");

        }
        
        public DbSet<Fault> Faults { get; set; }
        public DbSet<FaultOff> FaultOffs { get; set; }
        
    }
}
