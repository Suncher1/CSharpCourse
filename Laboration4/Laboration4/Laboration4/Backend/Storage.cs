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
        public void StoreAllProducts()
        {
            string productsInCsvFormat = $"id,title,genre,stock\n";
            foreach (Product product in products)
            {
                productsInCsvFormat += $"{product.id},{product.title},{product.genre},{product.stock}\n";
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

                //parsa data och lagra in i en produkt
                string[] dataValues = line.Split(',');
                Product product = new Product();
                product.id = Int32.Parse(dataValues[0]);
                product.title = dataValues[1];
                product.genre = dataValues[2];
                product.stock = Int32.Parse(dataValues[3]);
                products.Add(product);

                System.Console.WriteLine(line);
                counter++;
            }
        }

        public void AddProduct(int id, string title)
        {
            Product product = new Product();
            product.id = id;
            product.title = title;
            products.Add(product);
        }

        public Product GetProductByIndex(int currentSelectedIndex)
        {
            if(products == null || currentSelectedIndex+1 > products.Count || currentSelectedIndex == -1)
            {
                return null;
            }
            return products[currentSelectedIndex];
        }
        public void DeleteProductByIndex(int currentSelectedIndex)
        {
            if (products == null || currentSelectedIndex + 1 > products.Count)
            {
                return;
            }
            products.RemoveAt(currentSelectedIndex);
        }
    }
}

