using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppListPoc
{
    public class Storage
    {
        private List<Product> products;

        public Storage()
        {
            products = new List<Product>();
            products.Add(new Product(){Id=1, Title= "Produkt title 1", Description = "a small description", Stock = 12});
            products.Add(new Product() {Id=2, Title = "Produkt title 2", Description = "a large description", Stock = 5 });
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

    }
}
