using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FXMM.Entity
{
    public class Country : EntityBase
    {
        public string COUNTRY { get; set; }
        public string COUNTRY_DESCRIPTION { get; set; }
        public string ISO_CODE { get; set; }
        public virtual List<City> City { get; set; }
    }
}
