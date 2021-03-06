using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Dtos.ExhibitionDtos
{
    public class ExhibitionAnnouncementDto
    {
        public int ExhibitionAnnouncementID { get; set; }
        public string ExhibitionAnnouncementDescription { get; set; }

        public int ExhibitionID { get; set; }
        public ExhibitionDto Exhibition { get; set; }
    }
}
