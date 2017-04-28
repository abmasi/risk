using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FXMM.Entity
{
    public class LegalEntity : EntityBase
    {
        public string LegalEntityName { get; set; }
        public City City { get; set; }
        public Country Country { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public char IsCSAParticipant { get; set; } = 'N';
        public string ISDADescription { get; set; }
        public double Threshold { get; set; }
        public string Comment { get; set; }
    }
}
