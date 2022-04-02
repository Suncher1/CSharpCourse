using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppListPoc
{

    // https://social.technet.microsoft.com/wiki/contents/articles/53599.windows-forms-c-data-binding-listboxcombobox.aspx

    public partial class Form1 : Form
    {
        private Storage storage;

        //ObservableCollection<Product> data = new ObservableCollection<Product>();
        public Form1()
        {
            InitializeComponent();
            storage = new Storage();
            PopulateStorageAndShopList();
        }

        private void PopulateStorageAndShopList()
        {



            var allProducts = storage.GetAllProducts();

            listStorageBox.Items.Clear();
            listShopBox.Items.Clear();
            listBasketBox.Items.Clear();
            listStorageBox.DisplayMember = "ProductStockInfo";
            listShopBox.DisplayMember = "ProductStockInfo";
            listBasketBox.DisplayMember = "ProductReservedInfo";

            foreach (var product in allProducts)
            {
                listStorageBox.Items.Add(product);
                listShopBox.Items.Add(product);

                if (product.Reserved > 0)
                {
                    listBasketBox.Items.Add(product);
                }


            }









            //SelectionMode selectionMode = listBox1.SelectionMode;
            //listBox1.SelectionMode = SelectionMode.None;

            ////listBox1.DataSource = null;


            //var allProducts = storage.GetAllProducts();
            //listBox1.DataSource = allProducts;

            //listBox1.DisplayMember = "ProductStorageInfo";
            //listBox1.ValueMember = "Id";


            //listBox1.SelectionMode = selectionMode;



        }

        private void listStorageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)listStorageBox.SelectedItem;

            if (selectedProduct != null)
            {
                //selectedProduct.Title = selectedProduct.Title + " -...";
                //ShowDataInStorageListBox();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listShopBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)listShopBox.SelectedItem;

            if (selectedProduct != null)
            {
                btnAddToBasket.Enabled = true;
                btRemoveFromBasket.Enabled = false;

                //selectedProduct.Title = selectedProduct.Title + " -...";
                //ShowDataInStorageListBox();
            }
        }

        private void btnAddToBasket_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)listShopBox.SelectedItem;
            selectedProduct.Reserved++;
            selectedProduct.Stock--;
            PopulateStorageAndShopList();

        }

        private void btRemoveFromBasket_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)listBasketBox.SelectedItem;
            selectedProduct.Reserved--;
            selectedProduct.Stock++;
            PopulateStorageAndShopList();

        }

        private void listBasketBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)listBasketBox.SelectedItem;

            if (selectedProduct != null)
            {
                btnAddToBasket.Enabled = false;
                btRemoveFromBasket.Enabled = true;

                //selectedProduct.Title = selectedProduct.Title + " -...";
                //ShowDataInStorageListBox();
            }
        }
    }
    
}
