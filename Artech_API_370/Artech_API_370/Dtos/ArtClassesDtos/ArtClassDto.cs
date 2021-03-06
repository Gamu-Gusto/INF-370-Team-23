using Artech_API_370.Dtos.ExhibitionDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Dtos.ArtClassesDtos
{
    public class ArtClassDto
    {
        public int ArtClassID { get; set; }
        public string ArtClassName { get; set; }
        public string ArtClassDescription { get; set; }
        public DateTime ArtClassStartDate { get; set; }
        public DateTime ArtClassEndDate { get; set; }
        public DateTime ArtClassStartTime { get; set; }
        public DateTime ArtClassEndTime { get; set; }
        public int ClassLimit { get; set; }
        public int RefundDayLimit { get; set; }
        public double ClassPrice { get; set; }

        public int ArtClassTypeID { get; set; }
        public ArtClassTypeDto ArtClassType { get; set; }

        public int VenueID { get; set; }
        public VenueDto Venue { get; set; }
        
        public int ClassTeacherID { get; set; }
        public ClassTeacherDto ClassTeacher { get; set; }

        public int OrganisationID { get; set; }
        public OrganisationDto Organisation { get; set; }
    }
}
