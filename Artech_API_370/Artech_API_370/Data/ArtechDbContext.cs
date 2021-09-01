﻿using Artech_API_370.Entities;
using Artech_API_370.Entities.ArtClasses;
using Artech_API_370.Entities.Artists;
using Artech_API_370.Entities.Artworks;
using Artech_API_370.Entities.Exhibitions;
using Artech_API_370.Entities.Users;
using Artech_API_370.Exhibitions;
using BinaryBrainsAPI.Entities.Bookings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Data
{
    public class ArtechDbContext : DbContext
    {
        public ArtechDbContext(DbContextOptions<ArtechDbContext> options) : base(options)
        {


        }

        // Art Classes
        public DbSet<ArtClass> ArtClasse { get; set; }
        public DbSet<ArtClassType> ArtClassType { get; set; }
        public DbSet<TeacherType> TeacherType { get; set; }
        public DbSet<ClassTeacher> ClassTeacher { get; set; }
        public DbSet<ArtClassAnnouncement> ArtClassAnnouncement { get; set; }
        public DbSet<Feedback> Feedback { get; set; }

        // Artist 
        public DbSet<Invitation> Invitation { get; set; }
        public DbSet<InvitationStatus> InvitationStatus { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        // Artworks
        public DbSet<Artwork> Artwork { get; set; }
        public DbSet<SurfaceType> SurfaceType { get; set; }
        public DbSet<MediumType> MediumType { get; set; }
        public DbSet<FrameColour> FrameColour { get; set; }
        public DbSet<ArtworkType> ArtworkType { get; set; }
        public DbSet<ArtworkDimension> ArtworkDimension { get; set; }
        public DbSet<ArtworkStatus> ArtworkStatus { get; set; }

        // Exhibition
        public DbSet<Exhibition> Exhibition { get; set; }
        public DbSet<ExhibitionType> ExhibitionType { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<ScheduleType> ScheduleType { get; set; }
        public DbSet<Organisation> Organisation { get; set; }
        public DbSet<Venue> Venue { get; set; }
        public DbSet<ExhibitionAnnouncement> ExhibitionAnnouncement { get; set; }
        public DbSet<ExhibitionApplication> ExhibitionApplication { get; set; }
        public DbSet<ApplicationStatus> ApplicationStatus { get; set; }


        //Users
        public DbSet<User> User { get; set; }
        public DbSet<UserType> UserType { get; set; }
        public DbSet<Suburb> Suburb { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Privileges> Privileges { get; set; }

        // Bookings
        public DbSet<Booking> Booking { get; set; }
        public DbSet<BookingNotification> BookingNotification { get; set; }

        // Payment
        public DbSet<Payment> Payment { get; set; }
        public DbSet<PaymentType> PaymentType { get; set; }
        public DbSet<PaymentStatus> PaymentStatus { get; set; }
        public DbSet<Refund> Refund { get; set; }

        // Images
        public DbSet<Image> Image { get; set; }
        public DbSet<ImageType> ImageType { get; set; }
        public DbSet<UserTypePrivilege> UserTypePrivilege { get; set; }

        // Bridge Entities
        public DbSet<ExhibitionArtwork> ExhibitionArtwork { get; set; }
        public DbSet<UserInvitation> UserInvitation { get; set; }
    }
}
