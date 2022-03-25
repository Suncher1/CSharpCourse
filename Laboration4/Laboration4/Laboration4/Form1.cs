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
        #region validation
        private void textBoxPrice_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var isNumeric = int.TryParse(textBoxPrice.Text, out int n);
            if (!isNumeric)
            {
                string errorMsg = "Pris måste vara ett heltal!";
                e.Cancel = true;
                this.errorProvider.SetError(textBoxPrice, errorMsg);
            }
        }

        private void textBoxPrice_Validated(object sender, EventArgs e)
        {
            this.errorProvider.SetError(textBoxPrice, "");
        }

        private void textBoxId_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg = "";
            var isNumeric = int.TryParse(textBoxId.Text, out int n);
            if (!isNumeric)
            {
                errorMsg = "Id måste vara ett heltal!";
            }
            else
            {
                if (n < 0)
                {
                    errorMsg = "Id måste vara över 0!";
                }
            }
            if (errorMsg != "")
            {
                e.Cancel = true;
                this.errorProvider.SetError(textBoxId, errorMsg);
            }
        }

        private void textBoxId_Validated(object sender, EventArgs e)
        {
            this.errorProvider.SetError(textBoxId, "");
        }

        

        private void textBoxTitle_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxTitle.Text == "")
            {
                e.Cancel = true;
                this.errorProvider.SetError(textBoxTitle, "Titel kan inte vara tom!");
            }
        }

        private void textBoxTitle_Validated(object sender, EventArgs e)
        {
            this.errorProvider.SetError(textBoxTitle, "");
        }

        private void textBoxStock_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg = "";
            var isNumeric = int.TryParse(textBoxStock.Text, out int n);
            if (!isNumeric)
            {
                errorMsg = "Antal måste vara ett heltal!";
            }
            else
            {
                if(n < 0)
                {
                    errorMsg = "Antal måste vara minst 0!";
                }
            }
            if(errorMsg != "")
            {
                e.Cancel = true;
                this.errorProvider.SetError(textBoxStock, errorMsg);
            }
        }

        private void textBoxStock_Validated(object sender, EventArgs e)
        {
            this.errorProvider.SetError(textBoxStock, "");
        }
        #endregion
    }
}
