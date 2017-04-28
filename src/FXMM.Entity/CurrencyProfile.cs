using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FXMM.Entity
{
    public class CurrencyProfile : EntityBase
    {
        public string DenominatorCurrency { get; set; }
        public string BaseCurrency { get; set; }
        public int PointsDigit { get; set; }
        public int NumberofDecimals { get; set; }
        public int SpotLag { get; set; }
        public string QuotationMode { get; set; }
        public int SettlementLag { get; set; }
        public string Pair { get; set; }
        public char SpotAvailable { get; set; } = 'Y';
        public char IsFundingCurrency { get; set; } = 'Y';
    }
}
