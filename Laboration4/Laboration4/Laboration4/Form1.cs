using Laboration4.Backend;
using System;
using System.Windows.Forms;

namespace Laboration4
{
    public partial class Form1 : Form
    {
        //Global variables
        Storage storage;
        CashRegister cashRegister;
        Product selectedProduct;
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
            if (product == null)
            {
                MessageBox.Show("Kan inte hitta produkten");
            }
            else
            {
                selectedProduct = product;
                FillProductInput(product);
                buttonNewProduct.Enabled = true;
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            //storage.AddProduct(Int32.Parse(textBoxId.Text), textBoxName.Text);
            //DisplayProductsFromStorage();
            //ClearProductInput();
        }

        private void ClearProductInput()
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxAuthor.Text = "";
            textBoxGenre.Text = "";
            textBoxFormat.Text = "";
            textBoxLanguage.Text = "";
            textBoxPlatform.Text = "";
            textBoxGametime.Text = "";
            textBoxStock.Text = "";
            buttonDelete.Enabled = false;
            selectedProduct = null;
        }

        private void FillProductInput(Product product)
        {
            //id,namn,pris,författare,genre,format,språk,plattform,speltid,antal
            textBoxId.Text = product.id.ToString();
            textBoxName.Text = product.name;
            textBoxPrice.Text = product.price.ToString();
            textBoxAuthor.Text = product.author;
            textBoxGenre.Text = product.genre;
            textBoxFormat.Text = product.format;
            textBoxLanguage.Text = product.language;
            textBoxPlatform.Text = product.platform;
            textBoxGametime.Text = product.gametime;
            textBoxStock.Text = product.stock.ToString();
            buttonDelete.Enabled = true;
            buttonStoreProduct.Enabled = true;
        }

        private Product BuildProductFromInput()
        {
            Product product = new Product();

            var idParsed = Int32.TryParse(textBoxId.Text, out int idResult);
            if (idParsed)
            {
                product.id = idResult;
            }
            else
            {
                product.id = 0;
            }


            //product.id = Int32.Parse(textBoxId.Text);
            product.name = textBoxName.Text;


            var priceParsed = Int32.TryParse(textBoxPrice.Text, out int priceResult);
            if (priceParsed)
            {
                product.price = priceResult;
            }
            else
            {
                product.price = 0;
            }


            //product.price = Int32.Parse(textBoxPrice.Text);




            product.author = textBoxAuthor.Text;
            product.genre = textBoxGenre.Text;
            product.format = textBoxFormat.Text;
            product.language = textBoxLanguage.Text;
            product.platform = textBoxPlatform.Text;
            product.gametime = textBoxGametime.Text;
            //product.stock = Int32.Parse(textBoxStock.Text);
            var stockParsed = Int32.TryParse(textBoxStock.Text, out int stockResult);
            if (stockParsed)
            {
                product.stock = stockResult;
            }
            else
            {
                product.stock = 0;
            }


            return product;
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
                if (product.stock > 0)
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
                //Om det är en ny produkt
                if (selectedProduct == null)
                {
                    bool productIdAlreadyExist = storage.ProductIdExist(n);
                    if (productIdAlreadyExist)
                    {
                        errorMsg = "Välj en annan id då den är upptagen!";
                    }
                }
                //Uppdaterad produkt
                else
                {
                    if (n != selectedProduct.id)
                    {
                        bool productIdAlreadyExist = storage.ProductIdExist(n);
                        if (productIdAlreadyExist)
                        {
                            errorMsg = "Välj en annan id då den är upptagen!";
                        }
                    }
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
            if (textBoxName.Text == "")
            {
                e.Cancel = true;
                this.errorProvider.SetError(textBoxName, "Titel kan inte vara tom!");
            }
        }

        private void textBoxTitle_Validated(object sender, EventArgs e)
        {
            this.errorProvider.SetError(textBoxName, "");
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
                if (n < 0)
                {
                    errorMsg = "Antal måste vara minst 0!";
                }
            }
            if (errorMsg != "")
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

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {

        }

        private void buttonNewProduct_Click(object sender, EventArgs e)
        {
            DisplayProductsFromStorage();
            ClearProductInput();
            buttonNewProduct.Enabled = false;
        }

        private void buttonStoreProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
