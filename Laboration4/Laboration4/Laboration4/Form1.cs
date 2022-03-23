using Laboration4.Backend;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Laboration4
{
    public partial class Form1 : Form
    {
        //Global variables
        Storage storage;
        CashRegister cashRegister;
        public Form1()
        {
            InitializeComponent();
            storage = new Storage();
            cashRegister = new CashRegister();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            DisplayProductsFromStorage();
        }

        private void DisplayProductsFromStorage()
        { 
            var listProducts = storage.GetAllProducts();
            listBoxStorage.Items.Clear();
            foreach (Product product in listProducts)
            {
                listBoxStorage.Items.Add($"{product.id} {product.title} {product.genre}");
            }
        }
        //private void DisplayProductsStorage()
        //{
        //    listOfProducts.Items.Clear();

        //    foreach (Product product in listProducts)
        //    {
        //        listOfProducts.Items.Add($"{product.id} {product.title} {product.genre}");
        //    }
        //}

       

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                storage.StoreAllProducts();
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxStorage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
