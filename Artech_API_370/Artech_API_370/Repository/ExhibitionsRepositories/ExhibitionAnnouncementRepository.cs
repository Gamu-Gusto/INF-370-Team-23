using Artech_API_370.Data;
using Artech_API_370.Entities.Exhibitions;
using Artech_API_370.Exhibitions;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.ExhibitionsRepositories
{
    public class ExhibitionAnnouncementRepository : IAppRepository<ExhibitionAnnouncement>
    {
        readonly ArtechDbContext _artechDb;


        public ExhibitionAnnouncementRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(ExhibitionAnnouncement exhibitionAnnouncement)
        {
            _artechDb.ExhibitionAnnouncement.Add(exhibitionAnnouncement);
            _artechDb.SaveChanges();
        }

        public void Delete(ExhibitionAnnouncement exhibitionAnnouncement)
        {
            _artechDb.ExhibitionAnnouncement.Remove(exhibitionAnnouncement);
            _artechDb.SaveChanges();
        }

        public ExhibitionAnnouncement Get(long id)
        {
            return _artechDb.ExhibitionAnnouncement.FirstOrDefault(s => s.ExhibitionAnnouncementID == id);
        }

        public IEnumerable<ExhibitionAnnouncement> GetAll()
        {
            return _artechDb.ExhibitionAnnouncement.ToList();
        }

        public void Update(ExhibitionAnnouncement exhibitionAnnouncement, ExhibitionAnnouncement entity)
        {
            exhibitionAnnouncement.ExhibitionAnnouncementDescription = entity.ExhibitionAnnouncementDescription;
            _artechDb.SaveChanges();
        }
    }
}
