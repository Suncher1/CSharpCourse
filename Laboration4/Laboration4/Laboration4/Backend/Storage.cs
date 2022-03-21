using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4.Backend
{
    class Storage
    {
        List<Product> products;
        public Storage()
        {
            products = new List<Product>();
            //Läsa in producter från csv fil
        }
        public List<Product> GetAllProducts()
        {
            return products;
        }
        public void StoreAllProductsToCsv()
        {

        }
        public void ReadAllProductsFromCsv()
        {
            //Läs produkter från csv fil
            //Lägg till produkterna i product variabeln
        }
    }
}
