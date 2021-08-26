﻿using Artech_API_370.Data;
using Artech_API_370.Entities.Exhibitions;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.ExhibitionsRepositories
{
    public class ScheduleRepository : IAppRepository<Schedule>
    {
        readonly ArtechDbContext _artechDb;


        public ScheduleRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(Schedule schedule)
        {
            _artechDb.Schedule.Add(schedule);
            _artechDb.SaveChanges();
        }

        public void Delete(Schedule schedule)
        {
            _artechDb.Schedule.Remove(schedule);
            _artechDb.SaveChanges();
        }

        public Schedule Get(long id)
        {
            return _artechDb.Schedule.FirstOrDefault(s => s.ScheduleID == id);
        }

        public IEnumerable<Schedule> GetAll()
        {
            return _artechDb.Schedule.ToList();
        }

        public void Update(Schedule schedule, Schedule entity)
        {
            schedule.ScheduleName = entity.ScheduleName;
            schedule.ScheduleDescription = entity.ScheduleDescription;
            _artechDb.SaveChanges();
        }
    }
}
