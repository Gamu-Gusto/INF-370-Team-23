using Artech_API_370.Data;
using Artech_API_370.Entities.Users;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.UsersRepositories
{
    public class CountryRepository : IAppRepository<Country>
    {

        readonly ArtechDbContext _artechDb;


        public CountryRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(Country country)
        {
            _artechDb.Country.Add(country);
            _artechDb.SaveChanges();
        }

        public void Delete(Country country)
        {
            _artechDb.Country.Remove(country);
            _artechDb.SaveChanges();
        }

        public Country Get(long id)
        {
            return _artechDb.Country.FirstOrDefault(s => s.CountryID == id);
        }

        public IEnumerable<Country> GetAll()
        {
            return _artechDb.Country.ToList();
        }

        public void Update(Country country, Country entity)
        {
            country.CountryName = entity.CountryName;
            _artechDb.SaveChanges();
        }
    }
}
