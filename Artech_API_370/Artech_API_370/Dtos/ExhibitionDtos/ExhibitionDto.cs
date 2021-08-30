using Artech_API_370.Dtos.ExhibitionDtos;
using Artech_API_370.Dtos.ImageDtos;
using System;

namespace Artech_API_370.Dtos
{
    public class ExhibitionDto
    {
        public int ExhibitionID { get; set; }

        public string ExhibitionName { get; set; }

        public string ExhibitionDescription { get; set; }

        public DateTime ExhibitionDate { get; set; }

        public DateTime ExhibitionTime { get; set; }

        public int ExhibitionTypeID { get; set; }
        public ExhibitionTypeDto ExhibitionType { get; set; }

        public int ScheduleID { get; set; }
        public ScheduleDto Schedule { get; set; }

        public int OrganisationID { get; set; }
        public OrganisationDto Organisation { get; set; }

        public int VenueID { get; set; }
        public VenueDto Venue { get; set; }
        public int ImageID { get; set; }
        public ImagesDto Images { get; set; }
    }
}
