﻿using Artech_API_370.Entities.Images;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Entities.Users
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public int UserPhoneNumber { get; set; }
        public string UserPassword { get; set; }
        public DateTime UserDOB { get; set; }
        public string UserAddressLine1 { get; set; }
        public string UserAddressLine2 { get; set; }
        public int UserPostalCode { get; set; }
        public string ArtistBio { get; set; }

        // public string token { get; set; }

        [ForeignKey("UserTypeID")]
        public int UserTypeID { get; set; }
        public UserType UserType { get; set; }

        [ForeignKey("SuburbID")]
        public int SuburbID { get; set; }
        public Suburb Suburb { get; set; }

    }
}
