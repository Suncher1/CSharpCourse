using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4.Backend
{
    public class CashRegister
    {
        List<Product> shoppingCart;
        public CashRegister()
        {
            shoppingCart = new List<Product>();
            
        }
        public List<Product> GetAllProducts()
        {
            return shoppingCart;
        }
        public void AddProduct(Product product)
        {
            shoppingCart.Add(product);
        }

        public Product GetProductByIndex(int currentSelectedIndex)
        {
            if (shoppingCart == null || currentSelectedIndex + 1 > shoppingCart.Count || currentSelectedIndex == -1)
            {
                return null;
            }
            return shoppingCart[currentSelectedIndex];
        }
        public void DeleteProductByIndex(int currentSelectedIndex)
        {
            if (shoppingCart == null || currentSelectedIndex + 1 > shoppingCart.Count)
            {
                return;
            }
            shoppingCart.RemoveAt(currentSelectedIndex);
        }
        //public void UpdateProductByIndex(int currentSelectedIndex)
        //{
        //    if (shoppingCart == null || currentSelectedIndex + 1 > shoppingCart.Count)
        //    {
        //        return;
        //    }
        //    shoppingCart[currentSelectedIndex] = updatedProduct;
        //}
    }
}
