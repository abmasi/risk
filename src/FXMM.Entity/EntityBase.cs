using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FXMM.Entity
{
    public class EntityBase
    {
        public int Id { get; set; }
        public char IsActive { get; set; } = 'Y';
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
