using Artech_API_370.Dtos.ImageDtos;
using Artech_API_370.Dtos.UsersDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Dtos.ArtworksDtos
{
    public class ArtworkDto
    {
        public int ArtworkID { get; set; }
        public string ArtworkTitle { get; set; }
        public double ArtworkPrice { get; set; }
        public string ArtworkPicture { get; set; }
        public int SurfaceTypeID { get; set; }
        public SurfaceTypeDto SurfaceType { get; set; }
        public int MediumTypeID { get; set; }
        public MediumTypeDto MediumType { get; set; }
        public int ArtworkStatusID { get; set; }
        public ArtworkStatusDto ArtworkStatus { get; set; }
        public int FrameColourID { get; set; }
        public FrameColourDto FrameColour { get; set; }
        public int ArtworkDimensionID { get; set; }
        public ArtworkDimensionDto ArtworkDimension { get; set; }

        public int ImageID { get; set; }
        public ImagesDto Image { get; set; }

        public int UserID { get; set; }
        public UserDto User { get; set; }

        public int ArtworkTypeID { get; set; }
        public ArtworkTypeDto ArtworkType { get; set; }
    }
}
