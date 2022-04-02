﻿using System;
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
            //id,namn,pris,författare,genre,format,språk,plattform,speltid,antal
            string productsInCsvFormat = $"id,namn,pris,författare,genre,format,språk,plattform,speltid,antal\n";
            foreach (Product product in products)
            {
                productsInCsvFormat += $"{product.id},{product.name},{product.price}," +
                    $"{product.author},{product.genre},{product.format},{product.language}," +
                    $"{product.platform},{product.gametime},{product.stock}\n";
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
                product.id = Int32.Parse(dataValues[0]);
                product.name = dataValues[1];
                product.price = Int32.Parse(dataValues[2]);
                product.author = dataValues[3];
                product.genre = dataValues[4];
                product.format = dataValues[5];
                product.language = dataValues[6];
                product.platform = dataValues[7];
                product.gametime = dataValues[8];
                product.stock = Int32.Parse(dataValues[9]);
                product.reserved = 0;
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
                if (product.id == productId)
                {
                    return productPosition;
                }
                productPosition++;
            }

            return noProductIndexFound;
        }

        public Product GetProductById(int productId)
        {
            foreach (var product in products)
            {
                if (product.id == productId)
                {
                    return product;
                }
            }
            return null;
        }
    
        public void DeleteProductById(int productId)
        {
            int productIndex = GetProductIndexById(productId);

            if (productIndex >= 0)
            {
                products.RemoveAt(productIndex);
            }            
        }

        public void UpdateProductById(int productId, Product updatedProduct)
        {
            int productIndex = GetProductIndexById(productId);

            if (productIndex >= 0)
            {
                products[productIndex] = updatedProduct;
            }   
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
                    if (product.id == productId)
                    {
                        return true;
                    }
                }
                return false;
            }
        }


        #region byindex

        public Product GetProductByIndex(int currentSelectedIndex)
        {
            if (products == null || currentSelectedIndex + 1 > products.Count || currentSelectedIndex == -1)
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

        public void UpdateProductByIndex(int currentSelectedIndex, Product updatedProduct)
        {
            if (products == null || currentSelectedIndex + 1 > products.Count)
            {
                return;
            }
            products[currentSelectedIndex] = updatedProduct;
        }
        #endregion

    }
}

