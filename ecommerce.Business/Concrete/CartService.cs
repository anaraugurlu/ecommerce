using ecommerce.Business.Abstract;
using ecommerce.Entities.Concrete;
using ecommerce.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ecommerce.Business.Concrete
{
    public class CartService : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            var cartline = cart.CartLines.FirstOrDefault(c => c.Product.ProductId == product.ProductId);
            if (cartline!= null)
            {
                cartline.Quantity++;
                return;
            }
            cart.CartLines.Add(new CartLine { Product=product,Quantity=1});
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }

        public void RemoveFromCart(Cart cart, int productId)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Product.ProductId == productId));
        }
    }
}
