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
                listBoxStorage.Items.Add($"{product.id} {product.name} {product.genre}");
            }
        }

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
            var currentSelectedIndex = listBoxStorage.SelectedIndex;
            Console.WriteLine("CurrentSellexcrwetieam");
            var product = storage.GetProductByIndex(currentSelectedIndex);
            if(product == null)
            {
                MessageBox.Show("Kan inte hitta produkten");
            }
            else 
            { 
                FillProductInput(product); 
            }    
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            storage.AddProduct(Int32.Parse(textBoxId.Text), textBoxTitle.Text);
            DisplayProductsFromStorage();
            ClearProductInput();
        }

        private void ClearProductInput()
        {
            textBoxId.Text = "";
            textBoxTitle.Text = "";
        }

        private void FillProductInput(Product product)
        {
            textBoxId.Text = product.id.ToString();
            textBoxTitle.Text = product.name;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var currentSelectedIndex = listBoxStorage.SelectedIndex;
            Console.WriteLine("CurrentSellexcrwetieam");
            var product = storage.GetProductByIndex(currentSelectedIndex);
            if (product == null)
            {
                MessageBox.Show("Kan inte hitta produkten");
            }
            else
            {
                if(product.stock > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("", "Vill du verkligen radera produkten?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        storage.DeleteProductByIndex(currentSelectedIndex);
                        DisplayProductsFromStorage();
                        ClearProductInput();
                    } 
                }
                else
                {
                    storage.DeleteProductByIndex(currentSelectedIndex);
                    DisplayProductsFromStorage();
                    ClearProductInput();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
