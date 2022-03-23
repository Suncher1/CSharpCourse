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
            string productsInCsvFormat = $"id,title,genre\n";
            foreach (Product product in products)
            {
                productsInCsvFormat += $"{product.id},{product.title},{product.genre}\n";
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
                products.Add(product);

                System.Console.WriteLine(line);
                counter++;
            }
        }
    }
}

