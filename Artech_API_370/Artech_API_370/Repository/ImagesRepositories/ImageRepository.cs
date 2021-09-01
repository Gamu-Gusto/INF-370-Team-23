﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Repository.ImagesRepositories
{
    public class ImageRepository : IAppRepository<Image>
    {
        readonly ArtechDbContext _artechDb;


        public ImageRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(Image image)
        {
            _artechDb.Image.Add(image);
            _artechDb.SaveChanges();
        }

        public void Delete(Image image)
        {
            _artechDb.Image.Remove(image);
            _artechDb.SaveChanges();
        }

        public Image Get(long id)
        {
            return _artechDb.Image.FirstOrDefault(s => s.ImageID == id);
        }

        public IEnumerable<Image> GetAll()
        {
            return _artechDb.Image.ToList();
        }

        public void Update(Image image, Image entity)
        {
            image.ImageContent = entity.ImageContent;
            _artechDb.SaveChanges();
        }
    }
}
