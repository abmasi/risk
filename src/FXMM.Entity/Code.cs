namespace FXMM.Entity
{
    public enum BusinessDayConvention
    {
        NoAdjustment,
        NextGoodBusinessDay,
        PreviousGoodBusinessDay,
        ModifiedFollowingBusinessDay
    }

    public enum CashFlowType
    {
        Principal,
        Interest
    }

    public enum CompoundFrequency
    {
        Annual,
        SemiAnnual,
        Quarterly,
        BiMonthly,
        Monthly,
        Weekly,
        Daily
    }

    public enum CouponFrequency
    {
        Annual,
        SemiAnnual,
        Quarterly,
        BiMonthly,
        Monthly,
        Weekly,
        Daily,
        Discounted,
        InterestatMaturity,
        Days182
    }

    public enum InputMode
    {
        Captured,
        Generated,
        Imported
    }

    public enum InterestMethod
    {
        SimpleNoPrincipal,
        ArithmeticAverage,
        CompoundedAverageNoPrincipal,
        Simple,
        CompoundedAverage
    }

    public enum ModificationStatus
    {
        Locked,
        UnLocked
    }

    public enum SamplingFrequency
    {
        Annual,
        SemiAnnual,
        Quarterly,
        BiMonthly,
        Monthly,
        Weekly,
        Daily,
        MarketDays,
        AnnualNext,
        AnnualPrevious,
        SemiAnnualNext,
        SemiAnnualPrevious,
        QuartlyNext,
        QuartlyPrevious,
        MonthlyNext,
        MonthlyPrevious,
        Continious
    }

    public enum SettlementMode
    {
        Cash,
        Delivery
    }

    public enum SwapType
    {
        Round,
        NonRound,
        ForwardForwardRound
    }

    public enum ThirdpartyType
    {
        Bank,
        Government,
        Company,
        Individual,
        Exchange
    }

    public enum VolatilityType
    {
        ATM,
        Butterfly,
        RiskReversal,
        Strangle,
        Call_Delta,
        PutDelta
    }

    public enum YeildBasis
    {
        ACT360,
        ACT365,
        ACT365and25,
        ACThACT,
        T30360,
        T30E360,
        T30E360FEB,
        T30E1360ITLY,
        ACT365JAPAN,
        ACT365366,
        BUS252,
        ACTACT
    }

    public enum AverageCalculationMethod
    {
        Weighted,
        Unweighted
    }

    public enum EntryStatus
    {
        Open,
        Posted,
        Reversed,
        Cancelled
    }

    public enum EntryType
    {
        Executed,
        MTM,
        Receivable,
        Payable
    }

    public enum PublishStatus
    {
        Open,
        Confirmed,
        ManuallyPosted,
        ManuallyReversed,
        PostSent,
        PostFailed,
        PostRejected,
        ReversalSent,
        ReversalRejected,
        ReversalFailed
    }

    public enum NettingStatus
    {
        Available,
        Closed,
        Cancelled,
        Void
    }

    public enum NettingType
    {
        ExecutedCash,
        BondPrincipal,
        BondCoupon,
        MutualFundCashflow,
        FutureCashflow,
        Principal,
        DepositPrincipal,
        Interest,
        DepositInterest,
        ExecutedCashDeliverable,
        ExecutedCashNonDeliverable
    }

    public enum DealStatus
    {
        Matured,
        Expired,
        Open,
        Closed,
        Liquidated,
        Void,
        Exercised,
        Cancelled,
        CreditDefault
    }

    public enum ExerciseType
    {
        American,
        European
    }

    public enum FxType
    {
        FxOTCOption,
        FxSwapFarward,
        FxSwapSpot,
        DeliverableForward,
        NondeliverableForward,
        Spot,
        ForwardRateAgreement,
        InterestRateSwapPaying,
        InterestRateSwapReceiving,
        LoanDeposit,
        InterestAtMaturity,
        Future,
        Bond,
        ReverseRepo,
        TotalReturnSwap,
        TradableCd,
        MutualFunds,
        SpotForward,
        CreditDefaultSwap,
        FutureWithoutFifo
    }

    public class Code
        {
        }
}
