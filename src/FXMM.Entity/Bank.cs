using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FXMM.Entity
{
    public class Bank : EntityBase
    {
        public string BankName { get; set; }
        public string BankDescription { get; set; }
        public string AccountNumber { get; set; }
        public string SwiftCode { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }

    }
}
