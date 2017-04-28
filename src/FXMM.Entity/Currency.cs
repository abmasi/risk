using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FXMM.Entity
{
    public class Currency : EntityBase
    {
        public string CURRENCY { get; set; }
        public string CURRENCY_DESCRIPTION { get; set; }
        public int COUNTRY_ID { get; set; }
    }
}
