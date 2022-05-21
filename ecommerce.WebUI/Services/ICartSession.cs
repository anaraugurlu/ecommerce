using ecommerce.Northwind.Entities.Concrete;

namespace ecommerce.WebUI.Services
{
    public interface ICartSession
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}
