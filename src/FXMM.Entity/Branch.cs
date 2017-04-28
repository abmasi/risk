using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FXMM.Entity
{
    public class Branch : EntityBase
    {
        public string BranchName { get; set; }
        public string BranchDescription { get; set; }
        public string AccountingCurrency { get; set; }
        public int ConversionProfileId { get; set; }
        public string USDtoAccountingCurrency { get; set; }
        public string AccountingCurrencyToUSD { get; set; }
        public char GeneratePayments { get; set; } = 'N';
        public char GenerateAccountngEntries { get; set; } = 'N';
        public char IsAutomaticPosting { get; set; } = 'N';
        public int CountryId { get; set; }
        public string LocalCurrency { get; set; }
    }
}
