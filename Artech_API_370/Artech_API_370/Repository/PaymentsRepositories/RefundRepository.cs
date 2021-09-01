using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.PaymentsRepositories
{
    public class RefundRepository : IAppRepository<Refund>
    {
        readonly ArtechDbContext _artechDb;
        public RefundRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(Refund refund)
        {
            _artechDb.Refund.Add(refund);
            _artechDb.SaveChanges();
        }

        public void Delete(Refund refund)
        {
            _artechDb.Refund.Remove(refund);
            _artechDb.SaveChanges();
        }

        public Refund Get(long id)
        {
            return _artechDb.Refund.FirstOrDefault(s => s.RefundID == id);
        }

        public IEnumerable<Refund> GetAll()
        {
            return _artechDb.Refund.ToList();
        }

        public void Update(Refund refund, Refund entity)
        {
            refund.RefundStatus = entity.RefundStatus;
            _artechDb.SaveChanges();
        }
    }
}
