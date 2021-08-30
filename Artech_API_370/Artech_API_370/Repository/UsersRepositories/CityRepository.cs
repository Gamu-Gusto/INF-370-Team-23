using Artech_API_370.Data;
using Artech_API_370.Entities.Users;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.UsersRepositories
{
    public class CityRepository : IAppRepository<City>
    {
        readonly ArtechDbContext _artechDb;


        public CityRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(City city)
        {
            _artechDb.City.Add(city);
            _artechDb.SaveChanges();
        }

        public void Delete(City city)
        {
            _artechDb.City.Remove(city);
            _artechDb.SaveChanges();
        }

        public City Get(long id)
        {
            return _artechDb.City.FirstOrDefault(c => c.CityID == id);
        }

        public IEnumerable<City> GetAll()
        {
            return _artechDb.City.ToList();
        }

        public void Update(City city, City entity)
        {
            city.CityName = entity.CityName;
            _artechDb.SaveChanges();
        }

    }
}

