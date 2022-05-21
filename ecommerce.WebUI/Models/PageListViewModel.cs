using Microsoft.Extensions.Primitives;
using System.Collections.Generic;

namespace ecommerce.WebUI.Models
{
    public class PageListViewModel
    {
        public List<int> Pages { get; set; }
        public int CurrentPage { get; set; }
        public int Category { get; internal set; }
    }
}