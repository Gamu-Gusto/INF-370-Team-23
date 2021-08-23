using Artech_API_370.Data;
using Artech_API_370.Entities.Artists;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.ArtistsRepositories
{
    public class InvitationStatusRepository : IAppRepository<InvitationStatus>
    {
        readonly ArtechDbContext _artechDb;


        public InvitationStatusRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(InvitationStatus invitationStatus)
        {
            _artechDb.InvitationStatus.Add(invitationStatus);
            _artechDb.SaveChanges();
        }

        public void Delete(InvitationStatus invitationStatus)
        {
            _artechDb.InvitationStatus.Remove(invitationStatus);
            _artechDb.SaveChanges();
        }

        public InvitationStatus Get(long id)
        {
            return _artechDb.InvitationStatus.FirstOrDefault(s => s.InvitationStatusID == id);
        }

        public IEnumerable<InvitationStatus> GetAll()
        {
            return _artechDb.InvitationStatus.ToList();
        }

        public void Update(InvitationStatus invitationStatus, InvitationStatus entity)
        {
            invitationStatus.InvitationStatusDescription = entity.InvitationStatusDescription;
            _artechDb.SaveChanges();
        }
    }
}
