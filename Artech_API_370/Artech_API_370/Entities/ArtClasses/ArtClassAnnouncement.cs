using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Entities.ArtClasses
{
    public class ArtClassAnnouncement
    {
        [Key]
        public int ArtClassAnnouncementID { get; set; }
        public string ArtClassAnnouncementDescription { get; set; }

        [ForeignKey("ArtClassID")]
        public int ArtClassID { get; set; }
        public ArtClass ArtClass { get; set; }
    }
}
