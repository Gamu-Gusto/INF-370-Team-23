﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Entities.Artists
{
    public class InvitationStatus
    {
        [Key]
        public int InvitationStatusID { get; set; }
        public string InvitationStatusDescription { get; set; }
    }
}
