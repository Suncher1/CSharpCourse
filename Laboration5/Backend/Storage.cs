using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace Laboration4.Backend
{
    public class Storage
    {
        List<Product> products;
        readonly string productsCsvFile = $"{Directory.GetCurrentDirectory()}\\Csv\\Product.csv";
        string latestPurchase = "";

        public Storage()
        {
            products = new List<Product>();
            //Läsa in producter från csv fil
            ReadAllProducts();
        }
        public List<Product> GetAllProducts(string filter = "")
        {
            if (string.IsNullOrWhiteSpace(filter))
            {
                return products;
            }
            else
            {
                return products.Where(product => 
                    product.Name.Contains(filter) || 
                    product.Id.ToString().Contains(filter) ||
                    product.Author.Contains(filter)
                ).ToList(); 
            }

        }
        public List<Product> GetAllReservedProducts()
        {
            //https://stackoverflow.com/questions/54726354/get-all-objects-that-have-an-object-that-matches-a-string
            var reservedProducts = products.FindAll(product => product.Reserved > 0);
            return reservedProducts;
        }
        public void StoreAllProducts()
        {
            //id,namn,pris,författare,genre,format,språk,plattform,speltid,antal
            string productsInCsvFormat = $"id,namn,pris,författare,genre,format,språk,plattform,speltid,antal\n";
            foreach (Product product in products)
            {
                productsInCsvFormat += $"{product.Id},{product.Name},{product.Price}," +
                    $"{product.Author},{product.Genre},{product.Format},{product.Language}," +
                    $"{product.Platform},{product.Gametime},{product.Stock}\n";
            }
            File.WriteAllText(productsCsvFile, productsInCsvFormat);
        }
        private void ReadAllProducts()
        {
            //Läs produkter från csv fil
            //Lägg till produkterna i product variabeln
            int counter = 0;
            // Read the file and display it line by line.  
            foreach (string line in File.ReadLines(productsCsvFile))
            {
                if (counter == 0)
                {
                    counter++;
                    continue;
                }
                //id,namn,pris,författare,genre,format,språk,plattform,speltid,antal
                //parsa data och lagra in i en produkt
                string[] dataValues = line.Split(',');
                Product product = new Product();
                product.Id = Int32.Parse(dataValues[0]);
                product.Name = dataValues[1];
                product.Price = Int32.Parse(dataValues[2]);
                product.Author = dataValues[3];
                product.Genre = dataValues[4];
                product.Format = dataValues[5];
                product.Language = dataValues[6];
                product.Platform = dataValues[7];
                product.Gametime = dataValues[8];
                product.Stock = Int32.Parse(dataValues[9]);
                product.Reserved = 0;
                products.Add(product);

                System.Console.WriteLine(line);
                counter++;
            }
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public int GetProductIndexById(int productId)
        {
            int noProductIndexFound = -1;

            if (products == null || products.Count == 0)
            {
                return noProductIndexFound;
            }

            int productPosition = 0;
            foreach (var product in products)
            {
                if (product.Id == productId)
                {
                    return productPosition;
                }
                productPosition++;
            }

            return noProductIndexFound;
        }

        public void DeleteProduct(Product product)
        {
            int productIndex = GetProductIndexById(product.Id);

            if (productIndex >= 0)
            {
                products.RemoveAt(productIndex);
            }
        }

        public void UpdateProduct(Product originalProduct, Product updatedProduct)
        {
            originalProduct.Id = updatedProduct.Id;
            originalProduct.Name = updatedProduct.Name;
            originalProduct.Price = updatedProduct.Price;
            originalProduct.Author = updatedProduct.Author;
            originalProduct.Genre = updatedProduct.Genre;
            originalProduct.Format = updatedProduct.Format;
            originalProduct.Language = updatedProduct.Language;
            originalProduct.Platform = updatedProduct.Platform;
            originalProduct.Stock = updatedProduct.Stock;

            //int productIndex = GetProductIndexById(originalProduct.Id);

            //if (productIndex >= 0)
            //{
            //    products[productIndex] = updatedProduct;
            //}   
        }

        public bool ProductIdExist(int productId)
        {
            if (products == null || products.Count == 0)
            {
                return false;
            }
            else
            {
                //var product = products.Find(x => x.id == productId);
                foreach (var product in products)
                {
                    if (product.Id == productId)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public void CheckoutProducts()
        {
            latestPurchase = "KVITTO: \n";
            foreach (var product in products)
            {
                if (product.Reserved > 0)
                {
                    latestPurchase += $"{product.Name} Antal:{product.Reserved} Pris:{product.Price * product.Reserved}\n";
                    product.Stock = product.Stock - product.Reserved;
                    product.Reserved = 0;
                }
            }
            StoreAllProducts();
        }

        public string GetLatestPurchase()
        {
            return latestPurchase;
        }

        public bool SyncProductsFromRemoteStorage()
        {
            var productsFromXmlFile = new List<Product>();

            //https://stackoverflow.com/questions/5102865/asp-net-load-xml-file-from-url
            //Kontakta api och hämta alla produkter
            XmlDocument xdoc = new XmlDocument();//xml doc used for xml parsing

            xdoc.Load(
                "https://hex.cse.kau.se/~jonavest/csharp-api/"
                );//loading XML in xml doc

            XmlNodeList xNodelst = xdoc.DocumentElement.SelectNodes("products/*");//reading node so that we can traverse thorugh the XML

            string content = "";

            foreach (XmlNode xNode in xNodelst)//traversing XML 
            {
                content += "read";
                //Uppräta en ny produkt 
                //Läs värden från xml noden och lägra i produkten (Se exempel uppe på rad 55 i funktionen)
                //Lägg in produkten i products från xml filen rad 189
            }






            //Loppa igenom våra produkter som finns lokalt
            foreach (Product product in products)
            {
                if(product.Id == 3)
                {
                    product.Stock += 5;
                }
            }
            //För varje produkt så ska man läsa ut id, pris och lagerstatus
            //Om det är skillnad på pris eller lagerstatus så ska det uppdateras
            //Om det gått bra returneras true annars false
            return true;
        }
    }
}

