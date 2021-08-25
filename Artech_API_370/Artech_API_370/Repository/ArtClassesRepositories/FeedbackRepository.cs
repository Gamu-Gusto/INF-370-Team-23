using Artech_API_370.Data;
using Artech_API_370.Entities.ArtClasses;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.ArtClassesRepositories
{
    public class FeedbackRepository : IAppRepository<Feedback>
    {
        readonly ArtechDbContext _artechDb;


        public FeedbackRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(Feedback feedback)
        {
            _artechDb.Feedback.Add(feedback);
            _artechDb.SaveChanges();
        }

        public void Delete(Feedback feedback)
        {
            _artechDb.Feedback.Remove(feedback);
            _artechDb.SaveChanges();
        }

        public Feedback Get(long id)
        {
            return _artechDb.Feedback.FirstOrDefault(u => u.FeedbackID == id);
        }

        public IEnumerable<Feedback> GetAll()
        {
            return _artechDb.Feedback.ToList();
        }

        public void Update(Feedback feedback, Feedback entity)
        {
            feedback.FeedbackComment = entity.FeedbackComment;
            feedback.TeacherRating = entity.TeacherRating;
            feedback.DifficultyRating = entity.DifficultyRating;
            feedback.OverallRating = entity.OverallRating;
            _artechDb.SaveChanges();
        }
    }
}
