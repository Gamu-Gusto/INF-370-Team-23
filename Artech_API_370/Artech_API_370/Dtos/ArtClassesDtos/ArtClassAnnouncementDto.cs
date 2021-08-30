using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Dtos.ArtClassesDtos
{
    public class ArtClassAnnouncementDto
    {
        public int ArtClassAnnouncementID { get; set; }
        public string ArtClassAnnouncementDescription { get; set; }

        public int ArtClassID { get; set; }
        public ArtClassDto ArtClass { get; set; }
    }
}
