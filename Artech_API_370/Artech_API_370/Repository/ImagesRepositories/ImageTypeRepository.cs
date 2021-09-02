using Artech_API_370.Data;
using Artech_API_370.Entities.Images;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.ImagesRepositories
{
    public class ImageTypeRepository : IAppRepository<ImageType>
    {
        readonly ArtechDbContext _artechDb;
        public ImageTypeRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(ImageType imageType)
        {
            _artechDb.ImageType.Add(imageType);
            _artechDb.SaveChanges();
        }

        public void Delete(ImageType imageType)
        {
            _artechDb.ImageType.Remove(imageType);
            _artechDb.SaveChanges();
        }

        public ImageType Get(long id)
        {
            return _artechDb.ImageType.FirstOrDefault(s => s.ImageTypeID == id);
        }

        public IEnumerable<ImageType> GetAll()
        {
            return _artechDb.ImageType.ToList();
        }

        public void Update(ImageType imageType, ImageType entity)
        {
            imageType.ImageTypeDescription = entity.ImageTypeDescription;
            _artechDb.SaveChanges();
        }
    }
}
