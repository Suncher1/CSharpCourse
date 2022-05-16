using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public bool HasProducts()
        {
            if (products == null || products.Count == 0)
            {
                return false;
            }
            return true;
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
                    $"{product.Platform},{product.Playtime},{product.Stock}\n";
            }
            File.WriteAllText(productsCsvFile, productsInCsvFormat);
        }
        private void ReadAllProducts()
        {
            products = ReadAllProductsFromRemoteStorage();

            ////Läs produkter från csv fil
            ////Lägg till produkterna i product variabeln
            //int counter = 0;
            //// Read the file and display it line by line.  
            //foreach (string line in File.ReadLines(productsCsvFile))
            //{
            //    if (counter == 0)
            //    {
            //        counter++;
            //        continue;
            //    }
            //    //id,namn,pris,författare,genre,format,språk,plattform,speltid,antal
            //    //parsa data och lagra in i en produkt
            //    string[] dataValues = line.Split(',');
            //    Product product = new Product();
            //    product.Id = Int32.Parse(dataValues[0]);
            //    product.Name = dataValues[1];
            //    product.Price = Int32.Parse(dataValues[2]);
            //    product.Author = dataValues[3];
            //    product.Genre = dataValues[4];
            //    product.Format = dataValues[5];
            //    product.Language = dataValues[6];
            //    product.Platform = dataValues[7];
            //    if(!string.IsNullOrEmpty(dataValues[8]))
            //    {
            //        product.Playtime = Int32.Parse(dataValues[8]);
            //    } 
            //    else
            //    {
            //        product.Playtime = 0;
            //    }
            //    product.Stock = Int32.Parse(dataValues[9]);
            //    product.Reserved = 0;
            //    products.Add(product);
            //    counter++;
            //}
        }
        
        //En lista som får data om alla produkter från centrallagret
        private List<Product> ReadAllProductsFromRemoteStorage()
        {
            try
            {
                var productsFromXml = new List<Product>();

                //https://stackoverflow.com/questions/5102865/asp-net-load-xml-file-from-url
                //Kontakta api och hämta alla produkter
                XmlDocument xdoc = new XmlDocument();//xml doc used for xml parsing

                xdoc.Load(
                    "https://hex.cse.kau.se/~jonavest/csharp-api/"
                    );//loading XML in xml doc

                XmlNodeList xNodeProductList = xdoc.DocumentElement.SelectNodes("products/*");//reading node so that we can traverse thorugh the XML

                foreach (XmlNode xNodeProduct in xNodeProductList)//traversing XML 
                {

                    Product product = new Product();
                    product.Playtime = 0;
                    product.Reserved = 0;

                    foreach (XmlNode xNodeProductInfo in xNodeProduct.ChildNodes)
                    {
                        if (xNodeProductInfo.Name == "id")
                        {
                            product.Id = Int32.Parse(xNodeProductInfo.InnerText);
                        }
                        if (xNodeProductInfo.Name == "name")
                        {
                            product.Name = xNodeProductInfo.InnerText;
                        }
                        if (xNodeProductInfo.Name == "price")
                        {
                            product.Price = Int32.Parse(xNodeProductInfo.InnerText);
                        }
                        if (xNodeProductInfo.Name == "author")
                        {
                            product.Author = xNodeProductInfo.InnerText;
                        }
                        if (xNodeProductInfo.Name == "genre")
                        {
                            product.Genre = xNodeProductInfo.InnerText;
                        }
                        if (xNodeProductInfo.Name == "format")
                        {
                            product.Format = xNodeProductInfo.InnerText;
                        }
                        if (xNodeProductInfo.Name == "language")
                        {
                            product.Language = xNodeProductInfo.InnerText;
                        }
                        if (xNodeProductInfo.Name == "platform")
                        {
                            product.Platform = xNodeProductInfo.InnerText;
                        }
                        if (xNodeProductInfo.Name == "playtime")
                        {
                            product.Playtime = Int32.Parse(xNodeProductInfo.InnerText);
                        }
                        if (xNodeProductInfo.Name == "stock")
                        {
                            product.Stock = Int32.Parse(xNodeProductInfo.InnerText);
                        }
                    }
                    productsFromXml.Add(product);
                }
                return productsFromXml;
            }
            catch
            {
                return new List<Product>();
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
            //Först synkas produkterna
            SyncProductsFromRemoteStorage();
            latestPurchase = "KVITTO: \n";
            foreach (var product in products)
            {
                if (product.Reserved > 0)
                {
                    latestPurchase += $"{product.Name} Antal:{product.Reserved} Pris:{product.Price * product.Reserved}\n";
                    product.Stock = product.Stock - product.Reserved;
                    product.Reserved = 0;
                    //Anropa centrallagret och uppdaterar produkter som köpts
                    SyncOneProductToRemoteStorage(product.Id, product.Stock);
                }
            }
            //Produkterna synkas igen efter köpet
            SyncProductsFromRemoteStorage();
            StoreAllProducts();
        }

        public string GetLatestPurchase()
        {
            return latestPurchase;
        }

        //Funktion som synkroniserar det lokala lagret med data från xml url-en
        public bool SyncProductsFromRemoteStorage()
        {
            var remoteProducts = ReadAllProductsFromRemoteStorage();
            if (remoteProducts == null || remoteProducts.Count == 0)
            {
                return false;
            }
            //Loppa igenom våra produkter som finns lokalt
            foreach (Product product in products)
            {
                //Hämtar produkten med samma id på den lokala proudukten som den externa produkten
                var remoteProduct = remoteProducts.Where(p => p.Id == product.Id).Select(p => p).FirstOrDefault();

                if (remoteProduct != null)
                {
                    product.Price = remoteProduct.Price;
                    product.Stock = remoteProduct.Stock;
                }
            }
            return true;
        }

        //Funktion som synkroniserar xml url-en med data från det lokala lagret
        public bool SyncProductsToRemoteStorage()
        {
            try
            {
                //Lopar igenom varje produkt som ska synkriniseras
                foreach (Product product in products)
                {
                    SyncOneProductToRemoteStorage(product.Id, product.Stock);
                    
                    //var updateUrl = $"https://hex.cse.kau.se/~jonavest/csharp-api/?action=update&id={product.Id}&stock={product.Stock}";
                    ////https://www.codegrepper.com/code-examples/csharp/c%23+http+request
                    ////https://zetcode.com/csharp/httpclient/
                    //var client = new HttpClient();
                    //client.GetAsync(updateUrl).Wait();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Funktion som synkroniserar en produkt från det lokala lagret till xml url-en
        public bool SyncOneProductToRemoteStorage(int id, int stock)
        {
            try
            {
                var updateUrl = $"https://hex.cse.kau.se/~jonavest/csharp-api/?action=update&id={id}&stock={stock}";
                //https://www.codegrepper.com/code-examples/csharp/c%23+http+request
                //https://zetcode.com/csharp/httpclient/
                var client = new HttpClient();
                client.GetAsync(updateUrl).Wait();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

