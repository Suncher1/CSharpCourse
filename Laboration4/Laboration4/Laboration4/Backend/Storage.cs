using System;
using System.Collections.Generic;
using System.IO;

namespace Laboration4.Backend
{
    public class Storage
    {
        List<Product> products;
        readonly string productsCsvFile = $"{Directory.GetCurrentDirectory()}\\Csv\\Product.csv";

        public Storage()
        {
            products = new List<Product>();
            //Läsa in producter från csv fil
            ReadAllProducts();
        }
        public List<Product> GetAllProducts()
        {
            return products;
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



        /// <summary>
        /// return position of product with productId, otherwise -1
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        /// 

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
    }
}

