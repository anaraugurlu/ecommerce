using ecommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ecommerce.Business.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
