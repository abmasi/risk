using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FXMM.Entity
{
    public class Holiday : EntityBase
    {
        public DateTime HolidayDate { get; set; }
        public string HolidayDescription { get; set; }
        public int CountryId { get; set; }
        public int Year { get; set; } = DateTime.Now.Year;
    }
}
