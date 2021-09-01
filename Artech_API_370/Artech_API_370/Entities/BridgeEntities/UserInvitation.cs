using Artech_API_370.Entities.Artists;
using Artech_API_370.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Entities.BridgeEntities
{
    public class UserInvitation
    {
        [Key]
        public int UserInvitationID { get; set; }

        [ForeignKey("UserID")]
        public int? UserID { get; set; }
        public User User { get; set; }

        [ForeignKey("InvitationID")]
        public int? InvitationID { get; set; }
        public Invitation Invitation { get; set; }
    }
}
