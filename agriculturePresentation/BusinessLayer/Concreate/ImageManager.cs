using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class ImageManager : IImageService
    {
        private readonly IImageDal _imageService;

        public ImageManager(IImageDal imageService)
        {
            _imageService = imageService;
        }

        public void Delete(Image t)
        {
            _imageService.Delete(t);
        }

        public Image GetById(int id)
        {
            return _imageService.GetById(id);
        }

        public List<Image> GetListAll()
        {
            return _imageService.GetListAll();
        }

        public void Insert(Image t)
        {
            _imageService.Insert(t);
        }

        public void Update(Image t)
        {
            _imageService.Update(t);
        }
    }
}
