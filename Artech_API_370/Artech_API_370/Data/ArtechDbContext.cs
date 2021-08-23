﻿using Artech_API_370.Entities.ArtClasses;
using Artech_API_370.Entities.Artists;
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
        public DbSet<ArtClassType> ArtClassType { get; set; }

        // Artist 
        public DbSet<InvitationStatus> InvitationStatus { get; set; }

    }
}