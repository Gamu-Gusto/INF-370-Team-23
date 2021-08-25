using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Dtos.ArtClassesDtos
{
    public class FeedbackDto
    {
        public int FeedbackID { get; set; }
        public string FeedbackComment { get; set; }
        public double TeacherRating { get; set; }
        public double DifficultyRating { get; set; }
        public double OverallRating { get; set; }

        public int ArtClassID { get; set; }
        public ArtClassDto ArtClass { get; set; }
    }
}
