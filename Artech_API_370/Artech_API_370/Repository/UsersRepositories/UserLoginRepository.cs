using Artech_API_370.Data;
using Artech_API_370.Entities.Users;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.UsersRepositories
{
    public class UserLoginRepository : IIdentifier<User>
    {
        readonly ArtechDbContext _artechDb;


        public UserLoginRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }
        public User getUser(string UserName)
        {

            return _artechDb.User.FirstOrDefault(u => u.UserName == UserName);
        }
    }
}
