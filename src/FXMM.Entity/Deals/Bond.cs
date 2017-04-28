using System;

namespace FXMM.Entity.Deals
{
    public class Bond : EntityBase
    {
        public int DealMasterId { get; set; }
        public int DealBondSetupId { get; set; }
        public double FaceAmount { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public double Yield { get; set; }
        public double Accrued { get; set; }
        public double GrossAmount { get; set; }
        public DateTime ValueDate { get; set; }
        public DateTime SettlementDate { get; set; }
        public string BuySell { get; set; }
    }
}
