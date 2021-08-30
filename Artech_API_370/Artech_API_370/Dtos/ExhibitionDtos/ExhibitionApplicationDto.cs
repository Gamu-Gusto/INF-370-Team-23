using Artech_API_370.Dtos.ImageDtos;
using Artech_API_370.Dtos.UsersDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Dtos.ExhibitionDtos
{
    public class ExhibitionApplicationDto
    {
        public int ExhibitionApplicationID { get; set; }
        public string ApplicationDescription { get; set; }

        public int ExhibitionID { get; set; }
        public ExhibitionDto Exhibition { get; set; }

        public int ApplicationStatusID { get; set; }
        public ApplicationStatusDto ApplicationStatus { get; set; }

        public int ImageID { get; set; }
        public ImagesDto Images { get; set; }

        public int UserID { get; set; }
        public UserDto User { get; set; }
    }
}
