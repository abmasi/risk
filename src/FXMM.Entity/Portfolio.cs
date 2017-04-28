using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FXMM.Entity
{
    public class Portfolio : EntityBase
    {
        public string PortfolioName { get; set; }
        public string PortfolioDescription { get; set; }
        public Branch Branch { get; set; }
    }
}
