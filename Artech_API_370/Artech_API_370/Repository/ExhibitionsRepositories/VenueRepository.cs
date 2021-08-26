﻿using Artech_API_370.Data;
using Artech_API_370.Entities.Exhibitions;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.ExhibitionsRepositories
{
    public class VenueRepository : IAppRepository<Venue>
    {
        readonly ArtechDbContext _artechDb;


        public VenueRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(Venue venue)
        {
            _artechDb.Venue.Add(venue);
            _artechDb.SaveChanges();
        }

        public void Delete(Venue venue)
        {
            _artechDb.Venue.Remove(venue);
            _artechDb.SaveChanges();
        }

        public Venue Get(long id)
        {
            return _artechDb.Venue.FirstOrDefault(s => s.VenueID == id);
        }

        public IEnumerable<Venue> GetAll()
        {
            return _artechDb.Venue.ToList();
        }

        public void Update(Venue venue, Venue entity)
        {
            venue.VenueDescription = entity.VenueDescription;
            _artechDb.SaveChanges();
        }
    }
}
