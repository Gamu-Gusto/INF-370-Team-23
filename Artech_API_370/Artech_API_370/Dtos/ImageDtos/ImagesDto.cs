using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Dtos.ImageDtos
{
    public class ImagesDto
    {
        public int ImageID { get; set; }
        public byte ImageContent { get; set; }
        public int ImageTypeID { get; set; }
        public ImageTypeDto ImageType { get; set; }
    }
}
