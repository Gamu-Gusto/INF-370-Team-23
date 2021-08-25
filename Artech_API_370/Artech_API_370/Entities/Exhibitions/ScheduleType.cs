using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Entities.Exhibitions
{
    public class ScheduleType
    {
        [Key]
        public int ScheduleTypeID { get; set; }

        public string ScheduleTypeDescription { get; set; }
    }
}
