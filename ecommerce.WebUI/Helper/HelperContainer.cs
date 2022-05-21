using ecommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.WebUI.Helper
{
    public class HelperContainer
    {
        static public ObservableCollection<Product> Products { get; set; }
        static public int Cat { get; set; }
    }
}
