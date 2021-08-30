﻿using Artech_API_370.Data;
using Artech_API_370.Entities.Artworks;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.ArtworksRepositories
{
    public class ArtworkRepository : IAppRepository<Artwork>
    {
        readonly ArtechDbContext _artechDb;


        public ArtworkRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(Artwork artwork)
        {
            _artechDb.Artwork.Add(artwork);
            _artechDb.SaveChanges();
        }

        public void Delete(Artwork artwork)
        {
            _artechDb.Artwork.Remove(artwork);
            _artechDb.SaveChanges();
        }

        public Artwork Get(long id)
        {
            return _artechDb.Artwork.FirstOrDefault(s => s.ArtworkID == id);
        }

        public IEnumerable<Artwork> GetAll()
        {
            return _artechDb.Artwork.ToList();
        }

        public void Update(Artwork artwork, Artwork entity)
        {
            artwork.ArtworkTitle = entity.ArtworkTitle;
            artwork.ArtworkPrice = entity.ArtworkPrice;
            _artechDb.SaveChanges();
        }
    }
}
