using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FXMM.Entity
{
    public class DealMaster : EntityBase
    {
        public FXType FxType { get; set; }
        public int BlockNumber { get; set; }
        public CounterParty CounterParty { get; set; }
        public ThirdParty ThirdaParty { get; set; }
        public string dealComment { get; set; }
        public DealStatus DealStatus { get; set; }
        public CounterParty InternalCounterparty { get; set; }
        public InputMode InputMode { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime TradeDate { get; set; }
        public ModificationStatus Status { get; set; }
        public string ReasonForUnlock { get; set; }
        public string ReasonForVoid { get; set; }
        public UserInfo UnlockedBy { get; set; }
        public DateTime UnlockedOn { get; set; }
        public string UnlockedTo { get; set; }
        public char IsMatched { get; set; } = 'N';
        public DateTime DealDtatusUpdatedOn { get; set; }
        public UserInfo DealStatusUpdatedBy { get; set; }
        public string FxAllTraderName { get; set; }
        public string FxAllTradeId { get; set; }
        public DateTime PaymentGeneratedOn { get; set; }
        public DateTime DealInfoUpdatedOn { get; set; } = DateTime.Now;
    }
}
