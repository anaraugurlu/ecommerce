using ecommerce.Business.Abstract;
using ecommerce.WebUI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.WebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSession _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;

        public CartController(ICartSession cartSessionService,
            ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }
    
    }
}
