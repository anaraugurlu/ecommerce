using ecommerce.Business.Abstract;
using ecommerce.DataAccess.Abstract;
using ecommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ecommerce.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
