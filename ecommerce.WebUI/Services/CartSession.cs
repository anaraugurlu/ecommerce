using ecommerce.Northwind.Entities.Concrete;
using ecommerce.WebUI.ExtentionMethods;
using Microsoft.AspNetCore.Http;

namespace ecommerce.WebUI.Services
{
    public class CartSession : ICartSession
    {
        private IHttpContextAccessor _httpContextAccessor;

        public CartSession(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Cart GetCart()
        {
            var cart = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            if (cart == null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject("cart", new Cart());
                cart = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            }
            return cart;
        }

        public void SetCart(Cart cart)
        {
                _httpContextAccessor.HttpContext.Session.SetObject("cart", cart);
        }
    }
}
