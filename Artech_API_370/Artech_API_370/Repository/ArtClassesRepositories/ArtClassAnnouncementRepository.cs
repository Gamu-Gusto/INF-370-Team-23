using Artech_API_370.Data;
using Artech_API_370.Entities.ArtClasses;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.ArtClassesRepositories
{
    public class ArtClassAnnouncementRepository : IAppRepository<ArtClassAnnouncement>
    {

        readonly ArtechDbContext _artechDb;


        public ArtClassAnnouncementRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(ArtClassAnnouncement artClassAnnouncement)
        {
            _artechDb.ArtClassAnnouncement.Add(artClassAnnouncement);
            _artechDb.SaveChanges();
        }

        public void Delete(ArtClassAnnouncement artClassAnnouncement)
        {
            _artechDb.ArtClassAnnouncement.Remove(artClassAnnouncement);
            _artechDb.SaveChanges();
        }

        public ArtClassAnnouncement Get(long id)
        {
            return _artechDb.ArtClassAnnouncement.FirstOrDefault(u => u.ArtClassAnnouncementID == id);
        }

        public IEnumerable<ArtClassAnnouncement> GetAll()
        {
            return _artechDb.ArtClassAnnouncement.ToList();
        }

        public void Update(ArtClassAnnouncement artClassAnnouncement, ArtClassAnnouncement entity)
        {
            artClassAnnouncement.ArtClassAnnouncementDescription = entity.ArtClassAnnouncementDescription;
            _artechDb.SaveChanges();
        }
    }
}
