using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FXMM.Entity
{
    public class UserInfo : EntityBase
    {
        public string USER_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string EMAIL { get; set; }
        public string PHONE { get; set; }
        public DateTime LAST_LOGIN_DATE { get; set; }
        public int USER_GROUP_ID { get; set; }
        public int COUNTRY_ID { get; set; }
        public string LOGIN_NAME { get; set; }
        public List<Role> UserRole { get; set; }
    }
}
