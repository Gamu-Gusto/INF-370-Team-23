using Artech_API_370.Data;
using Artech_API_370.Entities.Exhibitions;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.ExhibitionsRepositories
{
    public class ScheduleTypeRepository : IAppRepository<ScheduleType>
    {
        readonly ArtechDbContext _artechDb;


        public ScheduleTypeRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(ScheduleType scheduleType)
        {
            _artechDb.ScheduleType.Add(scheduleType);
            _artechDb.SaveChanges();
        }

        public void Delete(ScheduleType scheduleType)
        {
            _artechDb.ScheduleType.Remove(scheduleType);
            _artechDb.SaveChanges();
        }

        public ScheduleType Get(long id)
        {
            return _artechDb.ScheduleType.FirstOrDefault(s => s.ScheduleTypeID == id);
        }

        public IEnumerable<ScheduleType> GetAll()
        {
            return _artechDb.ScheduleType.ToList();
        }

        public void Update(ScheduleType scheduleType, ScheduleType entity)
        {
            scheduleType.ScheduleTypeDescription = entity.ScheduleTypeDescription;
            _artechDb.SaveChanges();
        }
    }
}
