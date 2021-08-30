using Artech_API_370.Data;
using Artech_API_370.Entities.Artworks;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.ArtworksRepositories
{
    public class ArtworkDimensionRepository : IAppRepository<ArtworkDimension>
    {
        readonly ArtechDbContext _artechDb;


        public ArtworkDimensionRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(ArtworkDimension artworkDimension)
        {
            _artechDb.ArtworkDimension.Add(artworkDimension);
            _artechDb.SaveChanges();
        }

        public void Delete(ArtworkDimension artworkDimension)
        {
            _artechDb.ArtworkDimension.Remove(artworkDimension);
            _artechDb.SaveChanges();
        }

        public ArtworkDimension Get(long id)
        {
            return _artechDb.ArtworkDimension.FirstOrDefault(s => s.ArtworkDimensionID == id);
        }

        public IEnumerable<ArtworkDimension> GetAll()
        {
            return _artechDb.ArtworkDimension.ToList();
        }

        public void Update(ArtworkDimension artworkDimension, ArtworkDimension entity)
        {
            artworkDimension.ArtworkDimensionDescription = entity.ArtworkDimensionDescription;
            _artechDb.SaveChanges();
        }
    }
}
