using Artech_API_370.Data;
using Artech_API_370.Entities.Users;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.UsersRepositories
{
    public class AnnouncementRepository : IAppRepository<Announcement>
    {
        readonly ArtechDbContext _artechDb;


        public AnnouncementRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public IEnumerable<Announcement> GetAll()
        {

            return _artechDb.Announcement.ToList();
        }
        public void Add(Announcement announcement)
        {
            _artechDb.Announcement.Add(announcement);
            _artechDb.SaveChanges();
        }

        public void Delete(Announcement announcement)
        {
            _artechDb.Announcement.Remove(announcement);
            _artechDb.SaveChanges();

        }

        public Announcement Get(long id)
        {
            return _artechDb.Announcement.FirstOrDefault(u => u.AnnouncementID == id);
        }



        public void Update(Announcement announcement, Announcement entity)
        {
            announcement.AnnouncementTitle = entity.AnnouncementTitle;
            announcement.AnnouncementDescription = entity.AnnouncementDescription;
            _artechDb.SaveChanges();

        }
    }
}
