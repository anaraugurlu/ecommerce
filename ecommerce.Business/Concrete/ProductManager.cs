using ecommerce.Business.Abstract;
using ecommerce.DataAccess.Abstract;
using ecommerce.DataAccess.Concrete;
using ecommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ecommerce.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();

        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId || categoryId==0);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
