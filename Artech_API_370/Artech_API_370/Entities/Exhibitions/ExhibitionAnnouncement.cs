using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Artech_API_370.Entities;

namespace Artech_API_370.Exhibitions
{
    public class ExhibitionAnnouncement
    {
        [Key]
        public int ExhibitionAnnouncementID { get; set; }
        public string ExhibitionAnnouncementDescription { get; set; }

        [ForeignKey("ExhibitionID")]
        public int ExhibitionID { get; set; }
        public Exhibition Exhibition { get; set; }
    }
}
