﻿using Artech_API_370.Data;
using Artech_API_370.Entities.ArtClasses;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.ArtClassesRepositories
{
    public class ArtClassTypeRepository : IAppRepository<ArtClassType>
    {
        readonly ArtechDbContext _artechDb;


        public ArtClassTypeRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(ArtClassType artClassType)
        {
            _artechDb.ArtClassType.Add(artClassType);
            _artechDb.SaveChanges();
        }

        public void Delete(ArtClassType artClassType)
        {
            _artechDb.ArtClassType.Remove(artClassType);
            _artechDb.SaveChanges();
        }

        public ArtClassType Get(long id)
        {
            return _artechDb.ArtClassType.FirstOrDefault(s => s.ArtClassTypeID == id);
        }

        public IEnumerable<ArtClassType> GetAll()
        {
            return _artechDb.ArtClassType.ToList();
        }

        public void Update(ArtClassType artClassType, ArtClassType entity)
        {
            artClassType.ArtClassTypeDescription = entity.ArtClassTypeDescription;
            _artechDb.SaveChanges();
        }
    }
}
