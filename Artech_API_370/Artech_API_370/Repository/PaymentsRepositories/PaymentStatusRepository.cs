using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.PaymentsRepositories
{
    public class PaymentStatusRepository : IAppRepository<PaymentStatus>
    {
        readonly ArtechDbContext _artechDb;

        public PaymentStatusRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(PaymentStatus paymentStatus)
        {
            _artechDb.PaymentStatus.Add(paymentStatus);
            _artechDb.SaveChanges();
        }

        public void Delete(PaymentStatus paymentStatus)
        {
            _artechDb.PaymentStatus.Remove(paymentStatus);
            _artechDb.SaveChanges();
        }

        public PaymentStatus Get(long id)
        {
            return _artechDb.PaymentStatus.FirstOrDefault(s => s.PaymentStatusID == id);
        }

        public IEnumerable<PaymentStatus> GetAll()
        {
            return _artechDb.PaymentStatus.ToList();
        }

        public void Update(PaymentStatus paymentStatus, PaymentStatus entity)
        {
            paymentStatus.PaymentStatusDescription = entity.PaymentStatusDescription;
            _artechDb.SaveChanges();
        }
    }
}
