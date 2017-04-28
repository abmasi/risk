using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FXMM.Entity
{
    public class ThirdParty : EntityBase
    {
        public string THIRDPARTY { get; set; }
        public string ThirdpartyDescription { get; set; }
        public ThirdpartyType Type { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public char IsExchange { get; set; } = 'N';
        public City LegalEntityCity { get; set; }
        public Country LegalEntityCountry { get; set; }
        public char NettingAllowed { get; set; } = 'Y';
        public string TaxCode { get; set; }
        public LegalEntity LegalEntity { get; set; }
    }
}
