using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Entities.Users
{
    public class UserType
    {
        [Key]
        public int UserTypeID { get; set; }
        public string UserRoleName { get; set; }

        [ForeignKey("PrivilegesID")]
        public int? PrivilegesID { get; set; }
        public Privileges Privileges { get; set; }
    }
}
