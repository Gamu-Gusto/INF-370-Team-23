using Artech_API_370.Data;
using Artech_API_370.Entities.Users;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.UsersRepositories
{
    public class ProvinceRepository : IAppRepository<Province>
    {
        readonly ArtechDbContext _artechDb;


        public ProvinceRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(Province province)
        {
            _artechDb.Province.Add(province);
            _artechDb.SaveChanges();
        }

        public void Delete(Province province)
        {
            _artechDb.Province.Remove(province);
            _artechDb.SaveChanges();
        }

        public Province Get(long id)
        {
            return _artechDb.Province.FirstOrDefault(s => s.ProvinceID == id);
        }

        public IEnumerable<Province> GetAll()
        {
            return _artechDb.Province.ToList();
        }

        public void Update(Province province, Province entity)
        {
            province.ProvinceName = entity.ProvinceName;
            _artechDb.SaveChanges();
        }
    }
}

