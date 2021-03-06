using Artech_API_370.Data;
using Artech_API_370.Entities.Artworks;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.ArtworksRepositories
{
    public class MediumTypeRepository : IAppRepository<MediumType>
    {
        readonly ArtechDbContext _artechDb;


        public MediumTypeRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(MediumType mediumType)
        {
            _artechDb.MediumType.Add(mediumType);
            _artechDb.SaveChanges();
        }

        public void Delete(MediumType mediumType)
        {
            _artechDb.MediumType.Remove(mediumType);
            _artechDb.SaveChanges();
        }

        public MediumType Get(long id)
        {
            return _artechDb.MediumType.FirstOrDefault(s => s.MediumTypeID == id);
        }

        public IEnumerable<MediumType> GetAll()
        {
            return _artechDb.MediumType.ToList();
        }

        public void Update(MediumType mediumType, MediumType entity)
        {
            mediumType.MediumTypeName = entity.MediumTypeName;
            _artechDb.SaveChanges();
        }
    }
}
