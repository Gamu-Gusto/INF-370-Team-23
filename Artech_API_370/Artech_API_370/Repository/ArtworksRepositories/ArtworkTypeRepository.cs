using Artech_API_370.Data;
using Artech_API_370.Entities.Artworks;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.ArtworksRepositories
{
    public class ArtworkTypeRepository : IAppRepository<ArtworkType>
    {
        readonly ArtechDbContext _artechDb;


        public ArtworkTypeRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(ArtworkType artworkType)
        {
            _artechDb.ArtworkType.Add(artworkType);
            _artechDb.SaveChanges();
        }

        public void Delete(ArtworkType artworkType)
        {
            _artechDb.ArtworkType.Remove(artworkType);
            _artechDb.SaveChanges();
        }

        public ArtworkType Get(long id)
        {
            return _artechDb.ArtworkType.FirstOrDefault(s => s.ArtworkTypeID == id);
        }

        public IEnumerable<ArtworkType> GetAll()
        {
            return _artechDb.ArtworkType.ToList();
        }

        public void Update(ArtworkType artworkType, ArtworkType entity)
        {
            artworkType.ArtworkTypeDescription = entity.ArtworkTypeDescription;
            _artechDb.SaveChanges();
        }
    }
}
