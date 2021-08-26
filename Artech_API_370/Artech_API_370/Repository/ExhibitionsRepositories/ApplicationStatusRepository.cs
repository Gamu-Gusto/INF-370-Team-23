﻿using Artech_API_370.Data;
using Artech_API_370.Entities.Exhibitions;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.ExhibitionsRepositories
{
    public class ApplicationStatusRepository : IAppRepository<ApplicationStatus>
    {
        readonly ArtechDbContext _artechDb;


        public ApplicationStatusRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(ApplicationStatus applicationStatus)
        {
            _artechDb.ApplicationStatus.Add(applicationStatus);
            _artechDb.SaveChanges();
        }

        public void Delete(ApplicationStatus applicationStatus)
        {
            _artechDb.ApplicationStatus.Remove(applicationStatus);
            _artechDb.SaveChanges();
        }

        public ApplicationStatus Get(long id)
        {
            return _artechDb.ApplicationStatus.FirstOrDefault(s => s.ApplicationStatusID == id);
        }

        public IEnumerable<ApplicationStatus> GetAll()
        {
            return _artechDb.ApplicationStatus.ToList();
        }

        public void Update(ApplicationStatus applicationStatus, ApplicationStatus entity)
        {
            applicationStatus.ApplicationStatusDescription = entity.ApplicationStatusDescription;
            _artechDb.SaveChanges();
        }
    }
}
