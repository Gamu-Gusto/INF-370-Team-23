using Artech_API_370.Data;
using Artech_API_370.Entities.Exhibitions;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.ExhibitionsRepositories
{
    public class ExhibitionApplicationRepository : IAppRepository<ExhibitionApplication>
    {
        readonly ArtechDbContext _artechDb;


        public ExhibitionApplicationRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(ExhibitionApplication exhibitionApplication)
        {
            _artechDb.ExhibitionApplication.Add(exhibitionApplication);
            _artechDb.SaveChanges();
        }

        public void Delete(ExhibitionApplication exhibitionApplication)
        {
            _artechDb.ExhibitionApplication.Remove(exhibitionApplication);
            _artechDb.SaveChanges();
        }

        public ExhibitionApplication Get(long id)
        {
            return _artechDb.ExhibitionApplication.FirstOrDefault(s => s.ExhibitionApplicationID == id);
        }

        public IEnumerable<ExhibitionApplication> GetAll()
        {
            return _artechDb.ExhibitionApplication.ToList();
        }

        public void Update(ExhibitionApplication exhibitionApplication, ExhibitionApplication entity)
        {
            exhibitionApplication.ApplicationDescription = entity.ApplicationDescription;
            _artechDb.SaveChanges();
        }
    }
}
