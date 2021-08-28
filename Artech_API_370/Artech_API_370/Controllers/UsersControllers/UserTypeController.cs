﻿using Artech_API_370.Entities.Users;
using Artech_API_370.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Controllers.UsersControllers
{
    [Route("api/UserType")]
    
    public class UserTypeController : Controller
    {
        private readonly IAppRepository<UserType> _appRepository;

        public UserTypeController(IAppRepository<UserType> appRepository)
        {
            _appRepository = appRepository;
        }

        // GET: api/UserType
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<UserType> userTypes = _appRepository.GetAll();

            return Ok(userTypes);
        }

        // GET: api/UserType/{id}

        [HttpGet("{id}", Name = "GetUserType")]
        public IActionResult Get(long id)
        {
            UserType userType = _appRepository.Get(id);


            if (userType == null)
            {
                return NotFound("Requested User Type does not exist.");
            }

            return Ok(userType);
        }

        // GET: api/Create
        [HttpPost]
        public IActionResult Post([FromBody] UserType userType)
        {
            if (userType == null)
            {
                return BadRequest("User Type is null.");
            }
            _appRepository.Add(userType);
            return CreatedAtRoute(
                  "GetUserType",
                  new { Id = userType.UserTypeID },
                  userType);
        }

        // PUT: api/UserType/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] UserType userType)
        {
            if (userType == null)
            {
                return BadRequest("User Type is null.");
            }

            UserType userTypeToUpdate = _appRepository.Get(id);
            if (userTypeToUpdate == null)
            {
                return NotFound("The User Type does not exist.");
            }
            _appRepository.Update(userTypeToUpdate, userType);

            return NoContent();
        }


        // DELETE: api/UserType/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            UserType userType = _appRepository.Get(id);
            if (userType == null)
            {
                return NotFound("The User Type does not exist.");
            }
            _appRepository.Delete(userType);

            return NoContent();
        }
    }
}
