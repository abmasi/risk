using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FXMM.Entity
{
    public class AccruedBasis : EntityBase
    {
        public string Basis { get; set; }
        public string Description { get; set; }
        public Int16 Days { get; set; }
    }
}
