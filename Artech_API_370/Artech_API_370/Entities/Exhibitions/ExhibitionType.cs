using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Entities.Exhibitions
{
    public class ExhibitionType
    {
        [Key]
        public int ExhibitionTypeID { get; set; }
        public string ExhibitionTypeDecription { get; set; }
    }
}
