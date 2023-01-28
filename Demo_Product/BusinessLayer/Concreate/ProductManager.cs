using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class ProductManager : IGenericService<Product>
    {
        IProductDal _ProductDal;

        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }

        public Product GetById(int id)
        {
            return _ProductDal.GetById(id);
        }

        public List<Product> GetList()
        {
            return _ProductDal.GetList();
        }

        public void TDelete(Product t)
        {
            _ProductDal.Delete(t);
        }

        public void TInsert(Product t)
        {
            _ProductDal.Insert(t);
        }

        public void TUpdate(Product t)
        {
            _ProductDal.Update(t);
        }
    }
}
