﻿using Artech_API_370.Entities.Exhibitions;
using Artech_API_370.Entities.Images;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Entities
{
    public class Exhibition
    {
        [Key]
        public int ExhibitionID { get; set; }

        public string ExhibitionName { get; set; }

        public string ExhibitionDescription { get; set; }

        public DateTime ExhibitionDate { get; set; }

        public DateTime ExhibitionTime { get; set; }

        [ForeignKey("ExhibitionTypeID")]
        public int ExhibitionTypeID { get; set; }
        public ExhibitionType ExhibitionType { get; set; }

        [ForeignKey("ScheduleID")]
        public int ScheduleID { get; set; }
        public Schedule Schedule { get; set; }

        [ForeignKey("OrganisationID")]
        public int OrganisationID { get; set; }
        public Organisation Organisation { get; set; }

        [ForeignKey("VenueID")]
        public int VenueID { get; set; }
        public Venue Venue { get; set; }

        [ForeignKey("ImageID")]
        public int ImageID { get; set; }
        public Image Image { get; set; }

    }
}
