using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Dtos.ArtistsDtos
{
    public class InvitationDto
    {
        public int InvitationID { get; set; }
        public string InvitationDetails { get; set; }
        public DateTime InvitationDate { get; set; }

        public int ExhibitionID { get; set; }
        public ExhibitionDto Exhibition { get; set; }

        public int InvitationStatusID { get; set; }
        public InvitationStatusDto InvitationStatus { get; set; }
    }
}
