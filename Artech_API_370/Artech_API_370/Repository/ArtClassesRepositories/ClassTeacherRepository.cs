using Artech_API_370.Data;
using Artech_API_370.Entities.ArtClasses;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.ArtClassesRepositories
{
    public class ClassTeacherRepository : IAppRepository<ClassTeacher>
    {
        readonly ArtechDbContext _artechDb;


        public ClassTeacherRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(ClassTeacher classTeacher)
        {
            _artechDb.ClassTeacher.Add(classTeacher);
            _artechDb.SaveChanges();
        }

        public void Delete(ClassTeacher classTeacher)
        {
            _artechDb.ClassTeacher.Remove(classTeacher);
            _artechDb.SaveChanges();
        }

        public ClassTeacher Get(long id)
        {
            return _artechDb.ClassTeacher.FirstOrDefault(u => u.ClassTeacherID == id);
        }

        public IEnumerable<ClassTeacher> GetAll()
        {
            return _artechDb.ClassTeacher.ToList();
        }

        public void Update(ClassTeacher classTeacher, ClassTeacher entity)
        {
            classTeacher.TeacherName = entity.TeacherName;
            classTeacher.TeacherSurname = entity.TeacherSurname;
            classTeacher.TeacherEmail = entity.TeacherEmail;
            classTeacher.TeacherPhoneNumber = entity.TeacherPhoneNumber;
            _artechDb.SaveChanges();
        }
    }
}
