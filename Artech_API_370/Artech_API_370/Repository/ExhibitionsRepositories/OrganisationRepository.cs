﻿using Artech_API_370.Data;
using Artech_API_370.Entities.Exhibitions;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.ExhibitionsRepositories
{
    public class OrganisationRepository : IAppRepository<Organisation>
    {
        readonly ArtechDbContext _artechDb;


        public OrganisationRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(Organisation organisation)
        {
            _artechDb.Organisation.Add(organisation);
            _artechDb.SaveChanges();
        }

        public void Delete(Organisation organisation)
        {
            _artechDb.Organisation.Remove(organisation);
            _artechDb.SaveChanges();
        }

        public Organisation Get(long id)
        {
            return _artechDb.Organisation.FirstOrDefault(s => s.OrganisationID == id);
        }

        public IEnumerable<Organisation> GetAll()
        {
            return _artechDb.Organisation.ToList();
        }

        public void Update(Organisation organisation, Organisation entity)
        {
            organisation.OrganisationalAddress = entity.OrganisationalAddress;
            organisation.OrganisationalName = entity.OrganisationalName;
            _artechDb.SaveChanges();
        }
    }
}
