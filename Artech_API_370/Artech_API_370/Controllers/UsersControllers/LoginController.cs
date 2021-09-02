using Artech_API_370.Entities.Users;
using Artech_API_370.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Artech_API_370.Controllers.UsersControllers
{
    [Route("api/Login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IIdentifier<User> _appRepository;
        private readonly IAppRepository<User> _applicationRepository;

        bool isAuthenticated;
        public LoginController(IIdentifier<User> appRepository, IAppRepository<User> applicationRepository)
        {
            _appRepository = appRepository;

            _applicationRepository = applicationRepository;
        }



        [HttpGet("{username}/{password}", Name = "GetUserDetails")]
        public IActionResult Get(string username, string password)
        {
            User user = _appRepository.getUser(username);




            if (user == null)
            {
                return NotFound("Requested User does not exist.");
            }

            if (user != null && user.UserPassword == password)
            {
                isAuthenticated = true;

                int length = 13;

                RNGCryptoServiceProvider cryptRNG = new RNGCryptoServiceProvider();
                byte[] tokenBuffer = new byte[length];
                cryptRNG.GetBytes(tokenBuffer);

                string token = Convert.ToBase64String(tokenBuffer);

                user.UserPassword = token;


                return Ok(user);

            }


            if (user != null && user.UserPassword != password)
            {
                return NotFound("Password not matched with username.");
            }

            return Ok(user);
        }
    }
}
