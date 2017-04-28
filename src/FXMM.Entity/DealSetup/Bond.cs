using System;

namespace FXMM.Entity.DealSetup
{
    public class Bond : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ISINCusipCode { get; set; }
        public string Issuer { get; set; }
        public string Curreny { get; set; }
        public string SettlementCurrency { get; set; }
        public double FaceValue { get; set; }
        public double IssuePrice { get; set; }
        public double IssueAmount { get; set; }
        public double NoOfBondsIssued { get; set; }
        public double RedemptionValue { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime SettlementDate { get; set; }
        public DateTime FirstCouponDate { get; set; }
        public DateTime LastCouponDate { get; set; }
        public DateTime MaturityDate { get; set; }
        public string FixedFloating { get; set; } = "Fixed";
        public CouponFrequency CouponFrequency { get; set; }
        public double CouponRate { get; set; }
        public string YeildFormula { get; set; } = "ISMA-AIBD";
        public YeildBasis YeildBasis { get; set; }
        public AccruedBasis AccruedBasis { get; set; }
        public BusinessDayConvention BusinessDayConvention { get; set; }
        public int PaymentDateConversion { get; set; } = 0;
        public int SettlementDateConversion { get; set; } = 0;
        public string BusinessCalendar { get; set; } = "Business Days";
        public string Comment { get; set; }
        public Country Country { get; set; }
        public int InterestRateMapId { get; set; }
        public double FloatingRateMultiplier { get; set; }
        public double FloatingRateBPS { get; set; }
        public InterestMethod InterestMethod { get; set; }
        public int FixingFrequency { get; set; }
        public CompoundFrequency CompoundFrequency { get; set; }
    }
}
