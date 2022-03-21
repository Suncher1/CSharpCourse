using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Laboration4
{
    public partial class Form1 : Form
    {
        //Global variable
        readonly string productsCsvFile = $"{Directory.GetCurrentDirectory()}\\Csv\\Product.csv";
        List<Product> listProducts = new List<Product>();
        List<Product> shoppingCart = new List<Product>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            DisplayProducts();
        }

        private void DisplayProducts()
        {
            listOfProducts.Items.Clear();

            foreach (Product product in listProducts)
            {
                listOfProducts.Items.Add($"{product.id} {product.title} {product.genre}");
            }
        }

        public void LoadProducts()
        {
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
                listProducts.Add(product);

                System.Console.WriteLine(line);
                counter++;
            }

            Product fakeProduct = new Product();
            fakeProduct.id = 10;
            fakeProduct.title = "fake";
            fakeProduct.genre = "mer fake";
            listProducts.Add(fakeProduct);
        }

        public void StoreProducts()
        {
            //
            string productsInCsvFormat = $"id,title,genre\n";
            foreach (Product product in listProducts)
            {
                productsInCsvFormat += $"{product.id},{product.title},{product.genre}\n";
            }
            
            File.WriteAllText(productsCsvFile, productsInCsvFormat);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                StoreProducts();
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
