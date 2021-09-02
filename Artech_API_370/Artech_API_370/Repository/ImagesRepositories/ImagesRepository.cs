using Artech_API_370.Data;
using Artech_API_370.Entities.Images;
using Artech_API_370.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.ImagesRepositories
{
    public class ImagesRepository : IAppRepository<Image>
    {

        readonly ArtechDbContext _artechDb;


        public ImagesRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public virtual int Add(Image entity)
        {
            _artechDb.Image.Add(entity);

            _artechDb.SaveChanges();

            int id = entity.ImageID;

            return id;
        }

        public void Delete(Image entity)
        {
            throw new NotImplementedException();
        }

        public Image Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Image> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Image dbEntity, Image entity)
        {
            throw new NotImplementedException();
        }

        void IAppRepository<Image>.Add(Image entity)
        {
            throw new NotImplementedException();
        }
    }
}
