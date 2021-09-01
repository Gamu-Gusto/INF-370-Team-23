using Artech_API_370.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Entities.BridgeEntities
{
    public class UserTypePrivilege
    {
        [Key]
        public int UserTypePrivilegeID { get; set; }

        [ForeignKey("UserTypeID")]
        public int? UserTypeID { get; set; }
        public UserType UserType { get; set; }

        [ForeignKey("PrivilegesID")]
        public int? PrivilegesID { get; set; }
        public Privileges Privileges { get; set; }
    }
}
