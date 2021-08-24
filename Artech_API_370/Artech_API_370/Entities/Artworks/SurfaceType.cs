using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Entities.Artworks
{
    public class SurfaceType
    {
        [Key]
        public int SurfaceTypeID { get; set; }
        [Required]
        public string SurfaceTypeName { get; set; }
    }
}
