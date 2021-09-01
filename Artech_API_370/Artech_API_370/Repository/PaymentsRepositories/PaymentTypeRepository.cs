﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.PaymentsRepositories
{
    public class PaymentTypeRepository : IAppRepository<PaymentType>
    {
        readonly ArtechDbContext _artechDb;
        public PaymentTypeRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(PaymentType paymentType)
        {
            _artechDb.PaymentType.Add(paymentType);
            _artechDb.SaveChanges();
        }

        public void Delete(PaymentType paymentType)
        {
            _artechDb.PaymentType.Remove(paymentType);
            _artechDb.SaveChanges();
        }

        public PaymentType Get(long id)
        {
            return _artechDb.PaymentType.FirstOrDefault(s => s.PaymentTypeID == id);
        }

        public IEnumerable<PaymentType> GetAll()
        {
            return _artechDb.PaymentType.ToList();
        }

        public void Update(PaymentType paymentType, PaymentType entity)
        {
            paymentType.PaymentTypeDescription = entity.PaymentTypeDescription;
            _artechDb.SaveChanges();
        }
    }
}
