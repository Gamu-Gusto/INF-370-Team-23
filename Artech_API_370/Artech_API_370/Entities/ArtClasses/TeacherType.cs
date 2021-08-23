using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Entities.ArtClasses
{
    public class TeacherType
    {
        [Key]
        public int TeacherTypeID { get; set; }
        public string TeacherTypeDescription { get; set; }
    }
}
