﻿using Artech_API_370.Entities.Artworks;
using Artech_API_370.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Controllers.ArtworksControllers
{
    [Route("api/SurfaceType")]
    [ApiController]
    public class SurfaceTypeController : ControllerBase
    {
        private readonly IAppRepository<SurfaceType> _appRepository;

        public SurfaceTypeController(IAppRepository<SurfaceType> appRepository)
        {
            _appRepository = appRepository;
        }

        // GET: api/SurfaceType
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<SurfaceType> surfaceTypes = _appRepository.GetAll();

            return Ok(surfaceTypes);
        }

        // GET: api/SurfaceType/{id}

        [HttpGet("{id}", Name = "GetSurfaceType")]
        public IActionResult Get(long id)
        {
            SurfaceType surfaceType = _appRepository.Get(id);


            if (surfaceType == null)
            {
                return NotFound("Requested Surface Type does not exist.");
            }

            return Ok(surfaceType);
        }

        // GET: api/Create
        [HttpPost]
        public IActionResult Post([FromBody] SurfaceType surfaceType)
        {
            if (surfaceType == null)
            {
                return BadRequest("Surface Type is null.");
            }
            _appRepository.Add(surfaceType);
            return CreatedAtRoute(
                  "GetSurfaceType",
                  new { Id = surfaceType.SurfaceTypeID },
                  surfaceType);
        }

        // PUT: api/SurfaceType/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] SurfaceType surfaceType)
        {
            if (surfaceType == null)
            {
                return BadRequest("Surface Type is null.");
            }

            SurfaceType surfaceTypeToUpdate = _appRepository.Get(id);
            if (surfaceTypeToUpdate == null)
            {
                return NotFound("The Surface Type does not exist.");
            }
            _appRepository.Update(surfaceTypeToUpdate, surfaceType);

            return NoContent();
        }


        // DELETE: api/SurfaceType/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            SurfaceType surfaceType = _appRepository.Get(id);
            if (surfaceType == null)
            {
                return NotFound("The Surface Type does not exist.");
            }
            _appRepository.Delete(surfaceType);

            return NoContent();
        }
    }
}
