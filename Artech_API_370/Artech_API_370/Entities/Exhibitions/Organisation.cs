using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Entities.Exhibitions
{
    public class Organisation
    {
        [Key]
        public int OrganisationID { get; set; }
        public string OrganisationalAddress { get; set; }
        public string OrganisationalName { get; set; }
    }
}
