using Artech_API_370.Data;
using Artech_API_370.Entities.Artworks;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.ArtworksRepositories
{
    public class FrameColourRepository : IAppRepository<FrameColour>
    {
        readonly ArtechDbContext _artechDb;


        public FrameColourRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(FrameColour frameColour)
        {
            _artechDb.FrameColour.Add(frameColour);
            _artechDb.SaveChanges();
        }

        public void Delete(FrameColour frameColour)
        {
            _artechDb.FrameColour.Remove(frameColour);
            _artechDb.SaveChanges();
        }

        public FrameColour Get(long id)
        {
            return _artechDb.FrameColour.FirstOrDefault(s => s.FrameColourID == id);
        }

        public IEnumerable<FrameColour> GetAll()
        {
            return _artechDb.FrameColour.ToList();
        }

        public void Update(FrameColour frameColour, FrameColour entity)
        {
            frameColour.FrameColourDescription = entity.FrameColourDescription;
            _artechDb.SaveChanges();
        }
    }
}
