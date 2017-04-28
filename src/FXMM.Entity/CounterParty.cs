using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FXMM.Entity
{
    public class CounterParty : EntityBase
    {
        public string CounterPartyName { get; set; }
        public string CounterPartyDescription { get; set; }
        public Portfolio portfolio { get; set; }
        public char IncludeInVaR { get; set; } = 'Y';
        public string LimitCategory { get; set; }
        public string Comment { get; set; }
        public char IncludeFundingCurrencyExpo { get; set; } = 'N';
        public Currency Currency { get; set; }
        public char ExcludeFromNettingAccounting { get; set; } = 'N';
        public char DonotIncludePosition { get; set; } = 'N';
        public char DonotIncludePnL { get; set; } = 'N';
        public char UseUSDEquivalent { get; set; } = 'Y';
    }
}
