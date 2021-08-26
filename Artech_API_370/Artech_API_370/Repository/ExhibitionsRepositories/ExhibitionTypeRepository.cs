using Artech_API_370.Data;
using Artech_API_370.Entities.Exhibitions;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.ExhibitionsRepositories
{
    public class ExhibitionTypeRepository : IAppRepository<ExhibitionType>
    {
        readonly ArtechDbContext _artechDb;


        public ExhibitionTypeRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(ExhibitionType exhibitionType)
        {
            _artechDb.ExhibitionType.Add(exhibitionType);
            _artechDb.SaveChanges();
        }

        public void Delete(ExhibitionType exhibitionType)
        {
            _artechDb.ExhibitionType.Remove(exhibitionType);
            _artechDb.SaveChanges();
        }

        public ExhibitionType Get(long id)
        {
            return _artechDb.ExhibitionType.FirstOrDefault(s => s.ExhibitionTypeID == id);
        }

        public IEnumerable<ExhibitionType> GetAll()
        {
            return _artechDb.ExhibitionType.ToList();
        }

        public void Update(ExhibitionType exhibitionType, ExhibitionType entity)
        {
            exhibitionType.ExhibitionTypeDecription = entity.ExhibitionTypeDecription;
            _artechDb.SaveChanges();
        }
    }
}
