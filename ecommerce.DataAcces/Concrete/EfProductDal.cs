using ecommerce.Core.DataAccess.EntityFramework;
using ecommerce.DataAccess.Abstract;
using ecommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ecommerce.DataAccess.Concrete
{
    public class EfProductDal: EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
    }
}
