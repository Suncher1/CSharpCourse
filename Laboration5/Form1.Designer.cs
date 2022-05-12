
namespace Laboration4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listOfProducts = new System.Windows.Forms.ListBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabStore = new System.Windows.Forms.TabPage();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonReturnProduct = new System.Windows.Forms.Button();
            this.listBoxShoppingCart = new System.Windows.Forms.ListBox();
            this.buttonBuyProduct = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.tabStorage = new System.Windows.Forms.TabPage();
            this.buttonNewProduct = new System.Windows.Forms.Button();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxGametime = new System.Windows.Forms.TextBox();
            this.textBoxLanguage = new System.Windows.Forms.TextBox();
            this.textBoxPlatform = new System.Windows.Forms.TextBox();
            this.textBoxFormat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonStoreProduct = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxStorage = new System.Windows.Forms.ListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonSyncRemoteStorage = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.tabStore.SuspendLayout();
            this.tabStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfProducts
            // 
            this.listOfProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfProducts.FormattingEnabled = true;
            this.listOfProducts.ItemHeight = 24;
            this.listOfProducts.Location = new System.Drawing.Point(8, 54);
            this.listOfProducts.Name = "listOfProducts";
            this.listOfProducts.Size = new System.Drawing.Size(293, 340);
            this.listOfProducts.TabIndex = 0;
            this.listOfProducts.SelectedIndexChanged += new System.EventHandler(this.listOfProducts_SelectedIndexChanged);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabStore);
            this.TabControl.Controls.Add(this.tabStorage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(859, 450);
            this.TabControl.TabIndex = 1;
            // 
            // tabStore
            // 
            this.tabStore.Controls.Add(this.buttonReturn);
            this.tabStore.Controls.Add(this.buttonSearch);
            this.tabStore.Controls.Add(this.textBoxSearch);
            this.tabStore.Controls.Add(this.buttonReturnProduct);
            this.tabStore.Controls.Add(this.listBoxShoppingCart);
            this.tabStore.Controls.Add(this.buttonBuyProduct);
            this.tabStore.Controls.Add(this.buttonBuy);
            this.tabStore.Controls.Add(this.listOfProducts);
            this.tabStore.Location = new System.Drawing.Point(4, 22);
            this.tabStore.Name = "tabStore";
            this.tabStore.Padding = new System.Windows.Forms.Padding(3);
            this.tabStore.Size = new System.Drawing.Size(851, 424);
            this.tabStore.TabIndex = 0;
            this.tabStore.Text = "Butik";
            this.tabStore.UseVisualStyleBackColor = true;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Enabled = false;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(307, 357);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(84, 29);
            this.buttonReturn.TabIndex = 20;
            this.buttonReturn.Text = "Retur";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(217, 6);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(84, 29);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Sök";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(8, 6);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(203, 29);
            this.textBoxSearch.TabIndex = 18;
            // 
            // buttonReturnProduct
            // 
            this.buttonReturnProduct.Enabled = false;
            this.buttonReturnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnProduct.Location = new System.Drawing.Point(307, 207);
            this.buttonReturnProduct.Name = "buttonReturnProduct";
            this.buttonReturnProduct.Size = new System.Drawing.Size(105, 43);
            this.buttonReturnProduct.TabIndex = 17;
            this.buttonReturnProduct.Text = "<<";
            this.buttonReturnProduct.UseVisualStyleBackColor = true;
            this.buttonReturnProduct.Click += new System.EventHandler(this.buttonReturnProduct_Click);
            // 
            // listBoxShoppingCart
            // 
            this.listBoxShoppingCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxShoppingCart.FormattingEnabled = true;
            this.listBoxShoppingCart.ItemHeight = 24;
            this.listBoxShoppingCart.Location = new System.Drawing.Point(426, 51);
            this.listBoxShoppingCart.Name = "listBoxShoppingCart";
            this.listBoxShoppingCart.Size = new System.Drawing.Size(293, 340);
            this.listBoxShoppingCart.TabIndex = 16;
            this.listBoxShoppingCart.SelectedIndexChanged += new System.EventHandler(this.listBoxShoppingCart_SelectedIndexChanged);
            // 
            // buttonBuyProduct
            // 
            this.buttonBuyProduct.Enabled = false;
            this.buttonBuyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuyProduct.Location = new System.Drawing.Point(307, 146);
            this.buttonBuyProduct.Name = "buttonBuyProduct";
            this.buttonBuyProduct.Size = new System.Drawing.Size(105, 43);
            this.buttonBuyProduct.TabIndex = 15;
            this.buttonBuyProduct.Text = ">>";
            this.buttonBuyProduct.UseVisualStyleBackColor = true;
            this.buttonBuyProduct.Click += new System.EventHandler(this.buttonBuyProduct_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Enabled = false;
            this.buttonBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuy.Location = new System.Drawing.Point(725, 343);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(105, 43);
            this.buttonBuy.TabIndex = 14;
            this.buttonBuy.Text = "Köp Produkter";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // tabStorage
            // 
            this.tabStorage.Controls.Add(this.buttonSyncRemoteStorage);
            this.tabStorage.Controls.Add(this.buttonNewProduct);
            this.tabStorage.Controls.Add(this.textBoxStock);
            this.tabStorage.Controls.Add(this.textBoxGametime);
            this.tabStorage.Controls.Add(this.textBoxLanguage);
            this.tabStorage.Controls.Add(this.textBoxPlatform);
            this.tabStorage.Controls.Add(this.textBoxFormat);
            this.tabStorage.Controls.Add(this.label10);
            this.tabStorage.Controls.Add(this.label9);
            this.tabStorage.Controls.Add(this.label8);
            this.tabStorage.Controls.Add(this.label7);
            this.tabStorage.Controls.Add(this.label6);
            this.tabStorage.Controls.Add(this.buttonDelete);
            this.tabStorage.Controls.Add(this.buttonStoreProduct);
            this.tabStorage.Controls.Add(this.label5);
            this.tabStorage.Controls.Add(this.textBoxGenre);
            this.tabStorage.Controls.Add(this.textBoxAuthor);
            this.tabStorage.Controls.Add(this.textBoxPrice);
            this.tabStorage.Controls.Add(this.textBoxName);
            this.tabStorage.Controls.Add(this.textBoxId);
            this.tabStorage.Controls.Add(this.label4);
            this.tabStorage.Controls.Add(this.label3);
            this.tabStorage.Controls.Add(this.label2);
            this.tabStorage.Controls.Add(this.label1);
            this.tabStorage.Controls.Add(this.listBoxStorage);
            this.tabStorage.Location = new System.Drawing.Point(4, 22);
            this.tabStorage.Name = "tabStorage";
            this.tabStorage.Padding = new System.Windows.Forms.Padding(3);
            this.tabStorage.Size = new System.Drawing.Size(851, 424);
            this.tabStorage.TabIndex = 1;
            this.tabStorage.Text = "Lager";
            this.tabStorage.UseVisualStyleBackColor = true;
            // 
            // buttonNewProduct
            // 
            this.buttonNewProduct.Enabled = false;
            this.buttonNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewProduct.Location = new System.Drawing.Point(341, 330);
            this.buttonNewProduct.Name = "buttonNewProduct";
            this.buttonNewProduct.Size = new System.Drawing.Size(105, 43);
            this.buttonNewProduct.TabIndex = 24;
            this.buttonNewProduct.Text = "Ny Produkt";
            this.buttonNewProduct.UseVisualStyleBackColor = true;
            this.buttonNewProduct.Click += new System.EventHandler(this.buttonNewProduct_Click);
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(665, 235);
            this.textBoxStock.Multiline = true;
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(120, 30);
            this.textBoxStock.TabIndex = 23;
            this.textBoxStock.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxStock_Validating);
            this.textBoxStock.Validated += new System.EventHandler(this.textBoxStock_Validated);
            // 
            // textBoxGametime
            // 
            this.textBoxGametime.Location = new System.Drawing.Point(665, 189);
            this.textBoxGametime.Multiline = true;
            this.textBoxGametime.Name = "textBoxGametime";
            this.textBoxGametime.Size = new System.Drawing.Size(120, 30);
            this.textBoxGametime.TabIndex = 22;
            this.textBoxGametime.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxGametime_Validating);
            this.textBoxGametime.Validated += new System.EventHandler(this.textBoxGametime_Validated);
            // 
            // textBoxLanguage
            // 
            this.textBoxLanguage.Location = new System.Drawing.Point(665, 86);
            this.textBoxLanguage.Multiline = true;
            this.textBoxLanguage.Name = "textBoxLanguage";
            this.textBoxLanguage.Size = new System.Drawing.Size(120, 30);
            this.textBoxLanguage.TabIndex = 21;
            // 
            // textBoxPlatform
            // 
            this.textBoxPlatform.Location = new System.Drawing.Point(665, 139);
            this.textBoxPlatform.Multiline = true;
            this.textBoxPlatform.Name = "textBoxPlatform";
            this.textBoxPlatform.Size = new System.Drawing.Size(120, 30);
            this.textBoxPlatform.TabIndex = 8;
            // 
            // textBoxFormat
            // 
            this.textBoxFormat.Location = new System.Drawing.Point(665, 31);
            this.textBoxFormat.Multiline = true;
            this.textBoxFormat.Name = "textBoxFormat";
            this.textBoxFormat.Size = new System.Drawing.Size(120, 30);
            this.textBoxFormat.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(580, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Antal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(567, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Speltid";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(562, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Plattform";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(573, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Språk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(573, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Format";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(665, 330);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(105, 43);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Ta Bort";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonStoreProduct
            // 
            this.buttonStoreProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStoreProduct.Location = new System.Drawing.Point(497, 330);
            this.buttonStoreProduct.Name = "buttonStoreProduct";
            this.buttonStoreProduct.Size = new System.Drawing.Size(105, 43);
            this.buttonStoreProduct.TabIndex = 13;
            this.buttonStoreProduct.Text = "Lagra";
            this.buttonStoreProduct.UseVisualStyleBackColor = true;
            this.buttonStoreProduct.Click += new System.EventHandler(this.buttonUpdateProduct_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(336, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Genre";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(436, 235);
            this.textBoxGenre.Multiline = true;
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(120, 30);
            this.textBoxGenre.TabIndex = 11;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(436, 189);
            this.textBoxAuthor.Multiline = true;
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(120, 30);
            this.textBoxAuthor.TabIndex = 10;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(436, 139);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(120, 30);
            this.textBoxPrice.TabIndex = 9;
            this.textBoxPrice.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPrice_Validating);
            this.textBoxPrice.Validated += new System.EventHandler(this.textBoxPrice_Validated);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(436, 86);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(120, 30);
            this.textBoxName.TabIndex = 8;
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTitle_Validating);
            this.textBoxName.Validated += new System.EventHandler(this.textBoxTitle_Validated);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(436, 31);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(120, 30);
            this.textBoxId.TabIndex = 7;
            this.textBoxId.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxId_Validating);
            this.textBoxId.Validated += new System.EventHandler(this.textBoxId_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Författare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pris";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Namn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // listBoxStorage
            // 
            this.listBoxStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStorage.FormattingEnabled = true;
            this.listBoxStorage.ItemHeight = 24;
            this.listBoxStorage.Location = new System.Drawing.Point(8, 6);
            this.listBoxStorage.Name = "listBoxStorage";
            this.listBoxStorage.Size = new System.Drawing.Size(293, 340);
            this.listBoxStorage.TabIndex = 1;
            this.listBoxStorage.SelectedIndexChanged += new System.EventHandler(this.listBoxStorage_SelectedIndexChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // buttonSyncRemoteStorage
            // 
            this.buttonSyncRemoteStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSyncRemoteStorage.Location = new System.Drawing.Point(100, 352);
            this.buttonSyncRemoteStorage.Name = "buttonSyncRemoteStorage";
            this.buttonSyncRemoteStorage.Size = new System.Drawing.Size(105, 43);
            this.buttonSyncRemoteStorage.TabIndex = 25;
            this.buttonSyncRemoteStorage.Text = "Hämta Från Central Lager";
            this.buttonSyncRemoteStorage.UseVisualStyleBackColor = true;
            this.buttonSyncRemoteStorage.Click += new System.EventHandler(this.buttonSyncRemoteStorage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.tabStore.ResumeLayout(false);
            this.tabStore.PerformLayout();
            this.tabStorage.ResumeLayout(false);
            this.tabStorage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listOfProducts;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabStore;
        private System.Windows.Forms.TabPage tabStorage;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonStoreProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxStorage;
        private System.Windows.Forms.Button buttonBuyProduct;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxGametime;
        private System.Windows.Forms.TextBox textBoxLanguage;
        private System.Windows.Forms.TextBox textBoxPlatform;
        private System.Windows.Forms.TextBox textBoxFormat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button buttonNewProduct;
        private System.Windows.Forms.ListBox listBoxShoppingCart;
        private System.Windows.Forms.Button buttonReturnProduct;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonSyncRemoteStorage;
    }
}

