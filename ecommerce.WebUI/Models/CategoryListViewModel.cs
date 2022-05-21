using ecommerce.Entities.Concrete;
using System.Collections.Generic;

namespace ecommerce.WebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public int CurrentCategory { get; internal set; }
    }
}