using Laboration4.Backend;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Laboration4
{
    public partial class Form1 : Form
    {
        //Global variables
        Storage storage;
        Product selectedProduct;
        PrintDocument printDocument = new PrintDocument();
        PrintDialog printDialog = new PrintDialog();
        public Form1()
        {
            InitializeComponent();
            storage = new Storage();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string reciptText = storage.GetLatestPurchase();
            e.Graphics.DrawString(reciptText, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, 20, 20);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayProductsFromStorage();
        }

        private void DisplayProductsFromStorage()
        {
            //Hämtar produkter och visar i lager
            var listStorageProducts = storage.GetAllProducts();
            listBoxStorage.Items.Clear();
            listBoxStorage.DisplayMember = "DisplayInStorage";
            foreach (Product product in listStorageProducts)
            {
                listBoxStorage.Items.Add(product);
            }

            //Hämtar produkter och visar i butik
            var listStoreProducts = storage.GetAllProducts(textBoxSearch.Text);
            textBoxSearch.Text = "";
            listOfProducts.Items.Clear();
            listOfProducts.DisplayMember = "DisplayListOfProducts";
            foreach (Product product in listStoreProducts)
            {
                listOfProducts.Items.Add(product);
            }

            //Hämtar produkter som är reserverade och visar de i shoppinglistan
            var listReservedProducts = storage.GetAllReservedProducts();
            listBoxShoppingCart.Items.Clear();
            listBoxShoppingCart.DisplayMember = "DisplayReservedProducts";
            foreach (Product reservedProduct in listReservedProducts)
            {
                listBoxShoppingCart.Items.Add(reservedProduct);
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
            selectedProduct = (Product)listBoxStorage.SelectedItem;
            if (selectedProduct != null)
            {
                FillProductInput(selectedProduct);
                buttonNewProduct.Enabled = true;
            }
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
            buttonNewProduct.Enabled = false;
            selectedProduct = null;
        }

        private void FillProductInput(Product product)
        {
            //id,namn,pris,författare,genre,format,språk,plattform,speltid,antal
            textBoxId.Text = product.Id.ToString();
            textBoxName.Text = product.Name;
            textBoxPrice.Text = product.Price.ToString();
            textBoxAuthor.Text = product.Author;
            textBoxGenre.Text = product.Genre;
            textBoxFormat.Text = product.Format;
            textBoxLanguage.Text = product.Language;
            textBoxPlatform.Text = product.Platform;
            if(product.Playtime > 0)
            {
                textBoxGametime.Text = product.Playtime.ToString();
            }
            else
            {
                textBoxGametime.Text = "";
            }
            textBoxStock.Text = product.Stock.ToString();
            buttonDelete.Enabled = true;
            buttonStoreProduct.Enabled = true;
        }

        private Product BuildProductFromInput()
        {
            Product product = new Product();

            var idParsed = Int32.TryParse(textBoxId.Text, out int idResult);
            if (idParsed)
            {
                product.Id = idResult;
            }
            else
            {
                product.Id = 0;
            }
            product.Name = textBoxName.Text;


            var priceParsed = Int32.TryParse(textBoxPrice.Text, out int priceResult);
            if (priceParsed)
            {
                product.Price = priceResult;
            }
            else
            {
                product.Price = 0;
            }

            product.Author = textBoxAuthor.Text;
            product.Genre = textBoxGenre.Text;
            product.Format = textBoxFormat.Text;
            product.Language = textBoxLanguage.Text;
            product.Platform = textBoxPlatform.Text;

            var playtimeParsed = Int32.TryParse(textBoxGametime.Text, out int playtimeResult);
            if (playtimeParsed)
            {
                product.Playtime = playtimeResult;
            }
            else
            {
                product.Playtime = 0;
            }

            var stockParsed = Int32.TryParse(textBoxStock.Text, out int stockResult);
            if (stockParsed)
            {
                product.Stock = stockResult;
            }
            else
            {
                product.Stock = 0;
            }
            return product;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            selectedProduct = (Product)listBoxStorage.SelectedItem;
            if (selectedProduct == null)
            {
                MessageBox.Show("Kan inte hitta produkten");
            }
            else
            {
                if (selectedProduct.Stock > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("", "Vill du verkligen radera produkten?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        storage.DeleteProduct(selectedProduct);
                        DisplayProductsFromStorage();
                        ClearProductInput();
                    }
                }
                else
                {
                    storage.DeleteProduct(selectedProduct);
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
                if (n < 1)
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
                    if (n != selectedProduct.Id)
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
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                e.Cancel = true;
                this.errorProvider.SetError(textBoxName, "Titel kan inte vara tom!");
            }
        }

        private void textBoxTitle_Validated(object sender, EventArgs e)
        {
            this.errorProvider.SetError(textBoxName, "");
        }
        private void textBoxGametime_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxGametime.Text.Length > 0)
            {
                string errorMsg = "";
                var isNumeric = int.TryParse(textBoxGametime.Text, out int n);
                if (!isNumeric)
                {
                    errorMsg = "Speltid måste vara ett heltal!";
                }
                else
                {
                    if (n < 0)
                    {
                        errorMsg = "Speltid måste vara minst 0!";
                    }
                }
                if (errorMsg != "")
                {
                    e.Cancel = true;
                    this.errorProvider.SetError(textBoxGametime, errorMsg);
                }
            }
        }
        private void textBoxGametime_Validated(object sender, EventArgs e)
        {
            this.errorProvider.SetError(textBoxGametime, "");
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
            if (selectedProduct == null)
            {
                Product newProduct = BuildProductFromInput();
                if (newProduct.Id == 0 || string.IsNullOrWhiteSpace(newProduct.Name))
                {
                    MessageBox.Show("Du måste fylla i data för produkten");
                }
                else
                {
                    storage.AddProduct(newProduct);
                    DisplayProductsFromStorage();
                    ClearProductInput();
                }
            }
            else
            {
                selectedProduct = (Product)listBoxStorage.SelectedItem;
                if (selectedProduct != null)
                {
                    Product updatedProduct = BuildProductFromInput();
                    storage.UpdateProduct(selectedProduct, updatedProduct);
                    DisplayProductsFromStorage();
                    ClearProductInput();
                }



                //var currentSelectedIndex = listBoxStorage.SelectedIndex;
                //var product = storage.GetProductByIndex(currentSelectedIndex);
                //if (product == null)
                //{
                //    MessageBox.Show("Kan inte hitta produkten");
                //}
                //else
                //{
                //    //skapa ny produkt

                //}
            }
        }

        private void buttonNewProduct_Click(object sender, EventArgs e)
        {
            DisplayProductsFromStorage();
            ClearProductInput();
            buttonNewProduct.Enabled = false;
        }

        private void listOfProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct = (Product)listOfProducts.SelectedItem;
            if (selectedProduct != null)
            {
                buttonReturn.Enabled = true;
                if (selectedProduct.EligibleToBuy())
                {
                    buttonBuyProduct.Enabled = true;
                }
                else
                {
                    buttonBuyProduct.Enabled = false;
                }
            }
        }
        private void buttonBuyProduct_Click(object sender, EventArgs e)
        {
            buttonBuyProduct.Enabled = false;

            if (selectedProduct != null)
            {
                buttonBuy.Enabled = true;
                selectedProduct.Reserve();
                DisplayProductsFromStorage();
            }
        }

        private void listBoxShoppingCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct = (Product)listBoxShoppingCart.SelectedItem;
            if (selectedProduct != null)
            {
                buttonReturnProduct.Enabled = true;
            }
            else
            {
                buttonReturnProduct.Enabled = false;
            }
        }
        private void buttonReturnProduct_Click(object sender, EventArgs e)
        {
            buttonReturnProduct.Enabled = false;
            if (selectedProduct != null)
            {
                selectedProduct.UnReserve();
                if (storage.GetAllReservedProducts().Count == 0)
                {
                    buttonBuy.Enabled = false;
                }
                DisplayProductsFromStorage();
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            //Köper produkterna
            storage.CheckoutProducts();

            //print out recipt
            DialogResult dialogResult = MessageBox.Show("", "Vill du skriva ut kvitto?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                printDialog.Document = printDocument;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            //Visar ut en updaterad lista på produkterna och hur många som finns av varje
            DisplayProductsFromStorage();
            buttonBuy.Enabled = false;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DisplayProductsFromStorage();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            selectedProduct = (Product)listOfProducts.SelectedItem;
            buttonReturn.Enabled = false;
            if (selectedProduct != null)
            {
                selectedProduct.Return();
                DisplayProductsFromStorage();
            }   
        }

        private void buttonSyncRemoteStorage_Click(object sender, EventArgs e)
        {
            storage.SyncProductsFromRemoteStorage();
            DisplayProductsFromStorage();
        }
    }
}
