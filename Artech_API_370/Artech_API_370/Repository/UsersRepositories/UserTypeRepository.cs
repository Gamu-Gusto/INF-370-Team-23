using Artech_API_370.Data;
using Artech_API_370.Entities.Users;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.UsersRepositories
{
    public class UserTypeRepository : IAppRepository<UserType>
    {
        readonly ArtechDbContext _artechDb;


        public UserTypeRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(UserType userType)
        {
            _artechDb.UserType.Add(userType);
            _artechDb.SaveChanges();
        }

        public void Delete(UserType userType)
        {
            _artechDb.UserType.Remove(userType);
            _artechDb.SaveChanges();
        }

        public UserType Get(long id)
        {
            return _artechDb.UserType.FirstOrDefault(s => s.UserTypeID == id);
        }

        public IEnumerable<UserType> GetAll()
        {
            return _artechDb.UserType.ToList();
        }

        public void Update(UserType userType, UserType entity)
        {
            userType.UserRoleName = entity.UserRoleName;
            _artechDb.SaveChanges();
        }
    }
}

