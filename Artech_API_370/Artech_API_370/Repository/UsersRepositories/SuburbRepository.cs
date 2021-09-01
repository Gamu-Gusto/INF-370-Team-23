using Artech_API_370.Data;
using Artech_API_370.Entities.Users;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.UsersRepositories
{
    public class SuburbRepository : IAppRepository<Suburb>
    {
        readonly ArtechDbContext _artechDb;


        public SuburbRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(Suburb suburb)
        {
            _artechDb.Suburb.Add(suburb);
            _artechDb.SaveChanges();
        }

        public void Delete(Suburb suburb)
        {
            _artechDb.Suburb.Remove(suburb);
            _artechDb.SaveChanges();
        }

        public Suburb Get(long id)
        {
            return _artechDb.Suburb.FirstOrDefault(s => s.SuburbID == id);
        }

        public IEnumerable<Suburb> GetAll()
        {
            return _artechDb.Suburb.ToList();
        }

        public void Update(Suburb suburb, Suburb entity)
        {
            suburb.SuburbName = entity.SuburbName;
            _artechDb.SaveChanges();
        }
    }
}

